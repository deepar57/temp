using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Map
{
	public static class SectionViewModelMapper
	{
		public static void CopyTo(this Section section, SectionViewModel model)
		{
			model.Id = section.Id;
			model.Name = section.Name;
			model.Order = section.Order;
		}

		public static SectionViewModel CreateViewModel(this Section section)
		{
			SectionViewModel model = new SectionViewModel();
			section.CopyTo(model);
			return model;
		}

		public static void CopyTo(this SectionViewModel model, Section section)
		{
			section.Name = model.Name;
			section.Order = model.Order;
		}

		public static Section CreateEntity(this SectionViewModel model)
		{
			Section section = new Section();
			section.CopyTo(model);
			return section;
		}
	}
}
