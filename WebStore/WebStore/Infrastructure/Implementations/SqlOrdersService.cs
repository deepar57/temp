using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.DAL.Context;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Implementations
{
	public class SqlOrdersService : IOrdersService
	{
		private readonly WebStoreContext _db;
		private readonly UserManager<User> _userManager;

		public SqlOrdersService(WebStoreContext context, UserManager<User> userManager)
		{
			_db = context;
			_userManager = userManager;
		}

		public IEnumerable<Order> GetUserOrders(string userName)
		{
			return _db.Orders.Include(c => c.User).Include(c => c.OrderItems).Where(o => o.User.UserName.Equals(userName)).ToArray();
		}

		public Order GetOrderById(int id)
		{
			return _db.Orders.Include(c => c.OrderItems).FirstOrDefault(o => o.Id.Equals(id));
		}

		public Order CreateOrder(OrderViewModel orderModel, CartViewModel transformCart, string userName)
		{
			var user = _userManager.FindByNameAsync(userName).Result;

			using (var transaction = _db.Database.BeginTransaction())
			{
				var order = new Order()
				{
					Address = orderModel.Address,
					Name = orderModel.Name,
					Date = DateTime.Now,
					Phone = orderModel.Phone,
					User = user
				};

				_db.Orders.Add(order);

				foreach (var item in transformCart.Items)
				{
					var productVm = item.Key;
					var product = _db.Products.FirstOrDefault(p => p.Id.Equals(productVm.Id));
					if (product == null)
						throw new InvalidOperationException("Продукт не найден в базе");

					var orderItem = new OrderItem()
					{
						Order = order,
						Price = product.Price,
						Quantity = item.Value,
						Product = product
					};
					_db.OrderItems.Add(orderItem);
				}

				_db.SaveChanges();
				transaction.Commit();
				return order;
			}
		}
	}
}
