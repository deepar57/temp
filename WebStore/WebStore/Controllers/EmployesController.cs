using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Implementations;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Controllers
{
	//[Route("Users/[Action]")]
	public class EmployesController : Controller
	{
		private readonly IEmployeesData _EmployeesData;

		public EmployesController(IEmployeesData EmployeesData)
		{
			_EmployeesData = EmployeesData;
		}

		public IActionResult Index()
		{
			return View(_EmployeesData.GetAll());
		}

		//[Route("Info/{id}")]
		public IActionResult Details(int id)
		{
			var employee = _EmployeesData.GetById(id);
			if (employee == null)
				return NotFound();

			return View("EmployeeView", employee);
		}

		public ActionResult Edit(int? id)
		{
			Employee employee;
			if (id != null)
			{
				employee = _EmployeesData.GetById(id.Value);
				if (employee is null)
					return NotFound();
			}
			else
			{
				employee = new Employee();
			}
			return View(employee);
		}

		[HttpPost]
		public ActionResult Edit(Employee employee)
		{
			if (!ModelState.IsValid) return View(employee);

			if (employee.Id > 0)
			{
				Employee dbEmployee = _EmployeesData.GetById(employee.Id);
				if (dbEmployee is null)
					return NotFound();
				dbEmployee.SurName = employee.SurName;
				dbEmployee.FirstName = employee.FirstName;
				dbEmployee.Patronymic = employee.Patronymic;
				dbEmployee.Age = employee.Age;
				
			}
			else
			{
				_EmployeesData.AddNew(employee);
			}

			_EmployeesData.SaveChanges();

			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			Employee dbEmployee = _EmployeesData.GetById(id);
			if (dbEmployee is null)
				return NotFound();
			_EmployeesData.Delete(id);
			return RedirectToAction("Index");
		}
	}
}