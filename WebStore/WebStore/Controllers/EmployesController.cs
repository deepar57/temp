using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
	public class EmployesController : Controller
	{
		private static List<Employee> __Employes = new List<Employee>
		{
			new Employee() { Id = 0, SurName="Иванов", FirstName="Иван", Patronymic="Иванович", Age=25},
			new Employee() { Id = 1, SurName="Петров", FirstName="Петр", Patronymic="Иванович", Age=25},
			new Employee() { Id = 2, SurName="Сидоров", FirstName="Сидор", Patronymic="Иванович", Age=25},
		};

		public IActionResult Index()
		{
			return View(__Employes);
		}

		public IActionResult Details(int id)
		{
			var employee = __Employes.FirstOrDefault(c => c.Id == id);
			if (employee == null)
				return NotFound();

			return View(employee);
		}
	}
}