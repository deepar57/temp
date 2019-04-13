﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Map;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
	public class CatalogController : Controller
	{
		private readonly IProductData _ProductData;

		public CatalogController(IProductData ProductData)
		{
			_ProductData = ProductData;
		}

		public IActionResult Shop(int? SectionId, int? BrandId)
		{
			var products = _ProductData.GetProducts(new ProductFilter() { SectionId = SectionId, BrandId = BrandId });

			var catalog_models = new CatalogViewModel()
			{
				SectionId = SectionId,
				BrandId = BrandId,
				Products = products.Select(c => c.CreateViewModel())
			};

			return View(catalog_models);
		}
	}
}