using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Implementations
{
	public class CookieCartService : ICartService
	{
		private readonly IProductData _productData;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly string _cartName;

		private Cart Cart
		{
			get
			{
				var http_contexet = _httpContextAccessor.HttpContext;
				var cookie = http_contexet.Request.Cookies[_cartName];
				Cart cart = null;
				if (cookie is null)
				{
					cart = new Cart();
					http_contexet.Response.Cookies.Append(_cartName, JsonConvert.SerializeObject(cart));
				}
				else
				{
					cart = JsonConvert.DeserializeObject<Cart>(cookie);
					http_contexet.Response.Cookies.Delete(_cartName);
					http_contexet.Response.Cookies.Append(_cartName, JsonConvert.SerializeObject(cart), new CookieOptions()
					{
						Expires = DateTime.Now.AddDays(1)
					});
				}
				return cart;
			}

			set
			{
				var http_contexet = _httpContextAccessor.HttpContext;
				//var json = JsonConvert.SerializeObject(value);
				http_contexet.Response.Cookies.Delete(_cartName);
				http_contexet.Response.Cookies.Append(_cartName, JsonConvert.SerializeObject(value), new CookieOptions()
				{
					Expires = DateTime.Now.AddDays(1)
				});
			}
		}

		public CookieCartService(IProductData productData, IHttpContextAccessor httpContextAccessor)
		{
			_productData = productData;
			_httpContextAccessor = httpContextAccessor;

			var user = _httpContextAccessor.HttpContext.User;
			var user_Name = user.Identity.IsAuthenticated ? user.Identity.Name : null;
			_cartName = $"cart{user_Name}";
		}

		public void DecrementFromCart(int id)
		{
			var cart = Cart;
			var product = cart.Items.FirstOrDefault(c => c.ProductId == id);
			if (product != null)
			{
				if (product.Quantity > 0)
					product.Quantity--;
				if (product.Quantity == 0)
					cart.Items.Remove(product);
				Cart = cart;
			}

		}

		public void RemoveFromCart(int id)
		{
			var cart = Cart;
			var product = cart.Items.FirstOrDefault(c => c.ProductId == id);
			if (product != null)
			{
				cart.Items.Remove(product);
				Cart = cart;
			}
		}

		public void RemoveAll()
		{
			var cart = Cart;
			cart.Items.Clear();
			Cart = cart;
		}

		public void AddToCart(int id)
		{
			var cart = Cart;
			var product = cart.Items.FirstOrDefault(c => c.ProductId == id);
			if (product != null)
			{
				product.Quantity++;
			}
			else
			{
				cart.Items.Add(new CartItem() { ProductId = id, Quantity = 1 });
			}
			Cart = cart;
		}

		public CartViewModel TransformCart()
		{
			var products = _productData.GetProducts(new ProductFilter()
			{
				Ids = Cart.Items.Select(item => item.ProductId).ToList()
			});

			var product_view_models = products.Select(product => new ProductViewModel()
			{
				Id = product.Id,
				Name = product.Name,
				Order = product.Order,
				Price = product.Price,
				ImageUrl = product.ImageUrl,
				Brand = product.Brand?.Name
			});

			return new CartViewModel()
			{
				Items = Cart.Items.ToDictionary(c => product_view_models.First(p => p.Id == c.ProductId), c => c.Quantity)
			};
		}
	}
}
