﻿using System;
using System.Linq;
using VirtoCommerce.Foundation.AppConfig.Model;
using VirtoCommerce.Foundation.Frameworks;
using VirtoCommerce.ManagementClient.Core.Controls;
using VirtoCommerce.ManagementClient.Core.Infrastructure;
using linq = System.Linq.Expressions;


namespace VirtoCommerce.ManagementClient.AppConfig.Model
{
	[Serializable]
	public class ConditionCategoryIsSubcategory : TypedExpressionElementBase, IExpressionAdaptor
	{
		private CategorySelectElement _itemsInCategoryEl;

		public ConditionCategoryIsSubcategory(IExpressionViewModel expressionViewModel)
			: base("Category is subcategory of []".Localize(), expressionViewModel)
		{
			WithLabel("Category is subcategory of ".Localize());
			_itemsInCategoryEl = WithElement(new CategorySelectElement(expressionViewModel)) as CategorySelectElement;
			WithAvailableExcluding(() => new CategorySelectElement("Category".Localize(), expressionViewModel));
		}

		public string SelectedCategoryId
		{
			get
			{
				return _itemsInCategoryEl.SelectedCategoryId;
			}
			set
			{
				_itemsInCategoryEl.SelectedCategoryId = value;
			}
		}

		public linq.Expression<Func<IEvaluationContext, bool>> GetExpression()
		{
			linq.ParameterExpression paramX = linq.Expression.Parameter(typeof(IEvaluationContext), "x");
			var castOp = linq.Expression.MakeUnary(linq.ExpressionType.Convert, paramX, typeof(DisplayTemplateEvaluationContext));
			var methodInfo = typeof(DisplayTemplateEvaluationContext).GetMethod("IsCategorySubcategoryOf");
			var methodCall = linq.Expression.Call(castOp, methodInfo, linq.Expression.Constant(SelectedCategoryId)
													, ExcludingCategoryIds.GetNewArrayExpression());

			var retVal = linq.Expression.Lambda<Func<IEvaluationContext, bool>>(methodCall, paramX);

			return retVal;
		}

		public string[] ExcludingCategoryIds
		{
			get
			{
				return AllExcludingElements.OfType<CategorySelectElement>().Select(x => x.SelectedCategoryId).ToArray();
			}
			set
			{
				foreach (var categoryId in value)
				{
					var itemsInCategory = new CategorySelectElement(ExpressionViewModel);
					itemsInCategory.SelectedCategoryId = categoryId;
					this.AddExludingElement(itemsInCategory);
				}
			}
		}

		public string[] ExcludingProductIds
		{
			get
			{
				return AllExcludingElements.OfType<ItemSelectElement>().Select(x => x.SelectedItemId).ToArray();
			}
			set
			{
				foreach (var productId in value)
				{
					var itemsInProduct = new ItemSelectElement(ExpressionViewModel);
					itemsInProduct.SelectedItemId = productId;
					this.AddExludingElement(itemsInProduct);
				}
			}
		}

		public override void InitializeAfterDeserialized(IExpressionViewModel parentViewModel)
		{
			base.InitializeAfterDeserialized(parentViewModel);
			WithAvailableExcluding(() => new CategorySelectElement(parentViewModel));
			WithAvailableExcluding(() => new ItemSelectElement(parentViewModel));
		}
	}
}
