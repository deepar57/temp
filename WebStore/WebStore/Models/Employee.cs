using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Models
{
	public class Employee
	{
		[HiddenInput(DisplayValue = false)]
		public int Id { get; set; }

		[Display(Name = "Фамилия"), Required(ErrorMessage = "Имя является обязательным полем")]
		[MinLength(2)]
		public string SurName { get; set; }

		[Display(Name = "Имя"), Required(ErrorMessage = "Фамилия является обязательным полем")]
		[MinLength(2)]
		public string FirstName { get; set; }

		[Display(Name = "Отчество")]
		public string Patronymic { get; set; }

		[Display(Name = "Возраст")]
		[Range(18, 130)]
		public int Age { get; set; }
	}
}
