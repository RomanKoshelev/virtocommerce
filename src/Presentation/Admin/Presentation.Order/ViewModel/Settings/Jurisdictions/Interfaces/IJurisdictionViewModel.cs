﻿using VirtoCommerce.Foundation.Orders.Model.Countries;
using VirtoCommerce.ManagementClient.Core.Infrastructure;
using VirtoCommerce.Foundation.Orders.Model.Jurisdiction;

namespace VirtoCommerce.ManagementClient.Order.ViewModel.Settings.Jurisdictions.Interfaces
{
    public interface IJurisdictionViewModel : IViewModel
    {
        Jurisdiction InnerItem { get; }
		JurisdictionTypes[] AllAvailableJurisdictionTypes { get; }
		Country[] AllCountries { get; }
    }
}
