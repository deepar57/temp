using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Map;
using WebStore.ViewModels;

namespace WebStore.Components
{
	public class SectionsViewComponent : ViewComponent
	{
		private readonly IProductData _ProductData;

		public SectionsViewComponent(IProductData ProductData)
		{
			_ProductData = ProductData;
		}

		public IViewComponentResult Invoke()
		{
			return View(GetSections());
		}

		//public async Task<IViewComponentResult> InvokeAsync()
		//{
		//}

		private IEnumerable<SectionViewModel> GetSections()
		{
			var sections = _ProductData.GetSections();

			var parents = sections.Where(c => c.ParentId == null).Select(c => c.CreateViewModel()).ToList();

			foreach (var parentSection in parents)
			{
				var child_sections = sections.Where(c => c.ParentId == parentSection.Id).Select(c => c.CreateViewModel());
				parentSection.ChildSections.AddRange(child_sections);
				parentSection.ChildSections.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));
			}

			parents.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));

			return parents;
		}
	}
}
