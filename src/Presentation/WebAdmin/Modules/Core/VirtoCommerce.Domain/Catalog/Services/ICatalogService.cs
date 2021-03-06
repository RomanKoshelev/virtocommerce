﻿using VirtoCommerce.Domain.Catalog.Model;
using coreModel = VirtoCommerce.Domain.Catalog.Model;
namespace VirtoCommerce.Domain.Catalog.Services
{
	public interface ICatalogService
	{
		coreModel.Catalog GetById(string catalogId);
		coreModel.Catalog Create(coreModel.Catalog catalog);
		void Update(coreModel.Catalog[] catalogs);
		void Delete(string[] catalogIds);
	}
}