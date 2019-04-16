using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Filters;

namespace WebStore.Controllers
{
	public class HomeController : Controller
	{
		//[ActionFilterAsync]
		public IActionResult Index()
		{
			//throw new ApplicationException();
			return View();
		}

		public IActionResult ProductDetails()
		{
			return View();
		}

		public IActionResult ContactUs()
		{
			return View();
		}

		public IActionResult Checkout()
		{
			return View();
		}

		public IActionResult Cart()
		{
			return View();
		}

		public IActionResult Blog()
		{
			return View();
		}

		public IActionResult BlogSingle()
		{
			return View();
		}

		public IActionResult Error404()
		{
			return View();
		}
	}
}