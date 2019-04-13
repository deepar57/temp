﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Map
{
	public static class ProductViewModelMapper
	{
		public static void CopyTo(this Product product, ProductViewModel model)
		{
			model.Id = product.Id;
			model.Name = product.Name;
			model.Order = product.Order;
			model.ImageUrl = product.ImageUrl;
			model.Price = product.Price;
		}

		public static ProductViewModel CreateViewModel(this Product product)
		{
			ProductViewModel model = new ProductViewModel();
			product.CopyTo(model);
			return model;
		}

		public static void CopyTo(this ProductViewModel model, Product product)
		{
			product.Name = model.Name;
			product.Order = model.Order;
			product.ImageUrl = model.ImageUrl;
			product.Price = model.Price;
		}

		public static Product CreateEntity(this ProductViewModel model)
		{
			Product product = new Product();
			product.CopyTo(model);
			return product;
		}
	}
}