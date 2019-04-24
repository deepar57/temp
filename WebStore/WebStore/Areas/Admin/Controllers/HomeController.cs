using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = Domain.Entities.User.RoleAdmin)]
	public class HomeController : Controller
	{
		private readonly IProductData _ProductData;

		public HomeController(IProductData ProductData)
		{
			_ProductData = ProductData;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ProductList()
		{
			return View(_ProductData.GetProducts(new ProductFilter()));
		}
	}
}