using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Map
{
	public static class BrandViewModelMapper
	{
		public static void CopyTo(this Brand brand, BrandViewModel model, int productsCount = 0)
		{
			model.Id = brand.Id;
			model.Name = brand.Name;
			model.Order = brand.Order;
		}

		public static BrandViewModel CreateViewModel(this Brand brand)
		{
			BrandViewModel model = new BrandViewModel();
			brand.CopyTo(model);
			return model;
		}

		public static void CopyTo(this BrandViewModel model, Brand brand)
		{
			brand.Name = model.Name;
			brand.Order = model.Order;
		}

		public static Brand CreateEntity(this BrandViewModel model)
		{
			Brand brand = new Brand();
			model.CopyTo(brand);
			return brand;
		}
	}
}
