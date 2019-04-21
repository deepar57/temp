using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
	public class InMemoryProductData : IProductData
	{
		public IEnumerable<Section> GetSections() => TestData.Sections;

		public IEnumerable<Brand> GetBrands() => TestData.Brands;

		public IEnumerable<Product> GetProducts(ProductFilter Filter)
		{
			var products = (IEnumerable<Product>)TestData.Products;
			if (Filter is null) return products;
			if (Filter.BrandId != null)
				products = products.Where(c => c.BrandId == Filter.BrandId);
			if (Filter.SectionId != null)
				products = products.Where(c => c.SectionId == Filter.SectionId);
			return products;
		}

		public Product GetProductById(int id)
		{
			return TestData.Products.FirstOrDefault(c => c.Id == id);
		}
	}
}
