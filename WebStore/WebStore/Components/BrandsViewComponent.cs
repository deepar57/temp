using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Map;

namespace WebStore.Components
{
	public class BrandsViewComponent : ViewComponent
	{
		private readonly IProductData _ProductData;

		public BrandsViewComponent(IProductData ProductData)
		{
			_ProductData = ProductData;
		}

		public IViewComponentResult Invoke()
		{
			var brands = GetBrands();
			return View(brands);
		}

		private IEnumerable<BrandViewModel> GetBrands()
		{
			return _ProductData.GetBrands().Select(c => c.CreateViewModel());
		}
	}
}
