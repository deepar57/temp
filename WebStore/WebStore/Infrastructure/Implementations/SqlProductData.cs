using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL.Context;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
	public class SqlProductData : IProductData
	{
		private readonly WebStoreContext _db;

		public SqlProductData(WebStoreContext db)
		{
			_db = db;
		}

		public IEnumerable<Section> GetSections()
		{
			return _db.Sections.Include(s => s.Products).AsEnumerable();
		}

		public IEnumerable<Brand> GetBrands()
		{
			return _db.Brands.Include(s => s.Products).AsEnumerable();
		}

		public IEnumerable<Product> GetProducts(ProductFilter Filter)
		{
			IQueryable<Product> products = _db.Products;

			if (Filter is null)
				return products;

			if (Filter.BrandId != null)
				products = products.Where(c => c.BrandId == Filter.BrandId);

			if (Filter.SectionId != null)
				products = products.Where(c => c.SectionId == Filter.SectionId);

			return products.AsEnumerable();
		}

		public Product GetProductById(int id)
		{
			return _db.Products
			.Include(p => p.Brand)
			.Include(p => p.Section)
			.FirstOrDefault(c => c.Id == id);
		}
	}
}
