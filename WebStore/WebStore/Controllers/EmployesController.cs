using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Implementations;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Controllers
{
	//[Route("Users/[Action]")]
	[Authorize]
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

		[Authorize(Roles = Domain.Entities.User.RoleAdmin)]
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
		[Authorize(Roles = Domain.Entities.User.RoleAdmin)]
		public ActionResult Edit(Employee employee, [FromServices] IMapper mapper)
		{
			if (employee.Age < 18)
				ModelState.AddModelError("Age", "Возраст слишком маленький");

			if (employee.Age > 120)
				ModelState.AddModelError("Age", "Возраст слишком большой");

			//if (employee.Age % 2 == 0)
			//	ModelState.AddModelError("Age", "Четный возраст");

			if (!ModelState.IsValid) return View(employee);

			if (employee.Id > 0)
			{
				Employee dbEmployee = _EmployeesData.GetById(employee.Id);
				if (dbEmployee is null)
					return NotFound();

				//dbEmployee.SurName = employee.SurName;
				//dbEmployee.FirstName = employee.FirstName;
				//dbEmployee.Patronymic = employee.Patronymic;
				//dbEmployee.Age = employee.Age;

				//AutoMapper.Mapper.Map(employee, dbEmployee);

				mapper.Map(employee, dbEmployee);
			}
			else
			{
				_EmployeesData.AddNew(employee);
			}

			_EmployeesData.SaveChanges();

			return RedirectToAction("Index");
		}
		
		[Authorize(Roles = Domain.Entities.User.RoleAdmin)]
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