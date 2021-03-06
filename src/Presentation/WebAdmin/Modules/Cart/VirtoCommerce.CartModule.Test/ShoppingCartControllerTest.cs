﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtoCommerce.CartModule.Data.Repositories;
using VirtoCommerce.CartModule.Data.Services;
using VirtoCommerce.Domain.Cart.Model;
using VirtoCommerce.Domain.Cart.Services;
using VirtoCommerce.Foundation.Data.Infrastructure.Interceptors;
using VirtoCommerce.Foundation.Money;
using coreModel = VirtoCommerce.Domain.Cart.Model;
using webModel = VirtoCommerce.CatalogModule.Web.Model;
using VirtoCommerce.Foundation.Frameworks.Workflow.Services;
using VirtoCommerce.CartModule.Data.Workflow;

namespace VirtoCommerce.CartModule.Test
{
    using VirtoCommerce.CartModule.Web.Controllers.Api;

    [TestClass]
	public class ShoppingCartControllerTest
	{
		[TestMethod]
		public void GetCurrentCartTest()
		{
			var controller = GetCartController();
			var result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			Assert.IsNotNull(result.Content);
		}

		[TestMethod]
		public void AddItemToShoppingCart()
		{
			var controller = GetCartController();
			var result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			var cart = result.Content;

			var item = new webModel.LineItem
			{
				CatalogId = "catalog",
				CategoryId = "category",
				ProductId = "product",
				ListPrice = 10,
				PlacedPrice = 20,
				Quantity = 2,
				Name = "shoes",
				Currency = cart.Currency
			};
			cart.Items.Add(item);

			controller.Update(cart);

			result = controller.GetCartById(cart.Id) as OkNegotiatedContentResult<webModel.ShoppingCart>;
			cart = result.Content;


			Assert.IsNotNull(result.Content);
		}

		[TestMethod]
		public void TestCheckout()
		{
			var controller = GetCartController();
			var result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			var cart = result.Content;

			//Enter delivery address
			var deliveryAddress = new webModel.Address
			{
				Type = AddressType.Shipping,
				City = "london",
				Phone = "+68787687",
				PostalCode = "2222",
				CountryCode = "ENG",
				CountryName = "England",
				Email = "user@mail.com",
				FirstName = "first name",
				LastName = "last name",
				Line1 = "line 1",
				Organization = "org1"
			};
			cart.Addresses.Add(deliveryAddress);

			//Save changes
			controller.Update(cart);
			result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			cart = result.Content;

			//Select appropriate shipment method
			var shipmentMethodResult = controller.GetShipmentMethods(cart.Id) as OkNegotiatedContentResult<webModel.ShipmentMethod[]>;
			var shipmentMethod = shipmentMethodResult.Content.FirstOrDefault();
			var shipment = new webModel.Shipment
			{
				DeliveryAddress = deliveryAddress,
				Currency = shipmentMethod.Currency,
				ShipmentMethodCode = shipmentMethod.ShipmentMethodCode,
				ShippingPrice = shipmentMethod.Price
			};
			cart.Shipments.Add(shipment);

			//Save changes
			controller.Update(cart);
			result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			cart = result.Content;

			//Select payment method

			var paymentMethodResults = controller.GetPaymentMethods(cart.Id) as OkNegotiatedContentResult<webModel.PaymentMethod[]>;
			var paymentMethod = paymentMethodResults.Content.FirstOrDefault();

			//Enter billing address
			var billingAddress = new webModel.Address
			{
				Type = AddressType.Shipping,
				City = "london",
				Phone = "+68787687",
				PostalCode = "2222",
				CountryCode = "ENG",
				CountryName = "England",
				Email = "user@mail.com",
				FirstName = "first name",
				LastName = "last name",
				Line1 = "line 1",
				Organization = "org1"
			};
		
			var payment = new webModel.Payment
			{
				PaymentGatewayCode = paymentMethod.GatewayCode,
				BillingAddress = billingAddress,
				Currency = cart.Currency,
				Amount = cart.Total
			};
			cart.Payments.Add(payment);
			//Save changes
			controller.Update(cart);
			result = controller.GetCurrentCart("testSite") as OkNegotiatedContentResult<webModel.ShoppingCart>;
			cart = result.Content;

			//Next it call customer order method create order form cart
		}
		//[TestMethod]
		//public void SearchCarts()
		//{
		//	var controller = GetCartController();
		//	var result = controller.SearchCarts(new webModel.SearchCriteria { SiteId = "test" }) as OkNegotiatedContentResult<webModel.SearchResult>;
		//	Assert.IsNotNull(result.Content);
		//}

		private static CartController GetCartController()
		{
			Func<ICartRepository> repositoryFactory = () =>
			{
				return new CartRepositoryImpl("VirtoCommerce", new AuditableInterceptor(),
															   new EntityPrimaryKeyGeneratorInterceptor());
			};
			//Business logic for core model
			var cartWorkflowService = new ObservableWorkflowService<ShoppingCart>();
			//Subscribe to cart changes. Calculate totals  
			cartWorkflowService.Subscribe(new CalculateTotalsActivity());

			var cartService = new ShoppingCartServiceImpl(repositoryFactory, cartWorkflowService);
			var searchService = new ShoppingCartSearchServiceImpl(repositoryFactory);
			var controller = new CartController(cartService, searchService);
			return controller;
		}
	}
}
