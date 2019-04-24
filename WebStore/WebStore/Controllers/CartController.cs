using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartService _CartService;
		private readonly IOrdersService _OrdersService;

		public CartController(ICartService CartService, IOrdersService OrdersService)
		{
			_CartService = CartService;
			_OrdersService = OrdersService;
		}

		public IActionResult Details()
		{
			var model = new DetailsViewModel()
			{
				CartViewModel = _CartService.TransformCart(),
				OrderViewModel = new OrderViewModel()
			};

			return View(model);
		}

		public IActionResult DecrementFromCart(int id)
		{
			_CartService.DecrementFromCart(id);
			return RedirectToAction("Details");
		}

		public IActionResult RemoveFromCart(int id)
		{
			_CartService.RemoveFromCart(id);
			return RedirectToAction("Details");
		}

		public IActionResult RemoveAll()
		{
			_CartService.RemoveAll();
			return RedirectToAction("Details");
		}

		public IActionResult AddToCart(int id) //, string returnUrl)
		{
			_CartService.AddToCart(id);
			return RedirectToAction("Details");
			//return Redirect(returnUrl);
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult CheckOut(OrderViewModel model)
		{
			if (!ModelState.IsValid)
				return View(nameof(Details), new DetailsViewModel()
				{
					CartViewModel = _CartService.TransformCart(),
					OrderViewModel = model
				});

			var order = _OrdersService.CreateOrder(model, _CartService.TransformCart(), User.Identity.Name);

			_CartService.RemoveAll();

			return RedirectToAction("OrderConfirmed", new { Id = order.Id });
		}

		public IActionResult OrderConfirmed(int id)
		{
			ViewBag.OrderId = id;
			return View();
		}
	}
}