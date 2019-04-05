using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementations
{
	public class InMemoryEmployeesData : IEmployeesData
	{
		private static List<Employee> __Employes = new List<Employee>
		{
			new Employee() { Id = 1, SurName="Иванов", FirstName="Иван", Patronymic="Иванович", Age=25},
			new Employee() { Id = 2, SurName="Петров", FirstName="Петр", Patronymic="Иванович", Age=25},
			new Employee() { Id = 3, SurName="Сидоров", FirstName="Сидор", Patronymic="Иванович", Age=25},
		};

		public IEnumerable<Employee> GetAll()
		{
			return __Employes;
		}

		public Employee GetById(int id)
		{
			return __Employes.FirstOrDefault(c => c.Id == id);
		}

		public void AddNew(Employee employee)
		{
			if (employee == null) throw new ArgumentNullException(nameof(employee));
			if (!__Employes.Contains(employee) && !__Employes.Any(c => c.Id == employee.Id))
			{
				employee.Id = (__Employes.Count > 0) ? __Employes.Max(c => c.Id) + 1 : 1;
				__Employes.Add(employee);
			}
		}

		public void Delete(int id)
		{
			Employee employee = GetById(id);
			if (!(employee is null))
				__Employes.Remove(employee);
		}

		public void SaveChanges()
		{
		}
	}
}
