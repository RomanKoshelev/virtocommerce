﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Foundation.Frameworks;

namespace VirtoCommerce.Domain.Cart.Model
{
	public class PaymentMethod : ValueObject<PaymentMethod>
	{
		public string GatewayCode { get; set; }
		public string Name { get; set; }
		public string IconUrl { get; set; }
	}
}
