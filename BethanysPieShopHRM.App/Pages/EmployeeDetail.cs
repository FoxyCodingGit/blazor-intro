using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter]
		public string EmployeeId { get; set; }

		public Employee Employee { get; set; } = new Employee();

		// As component rather than class can use this "Inject" attribute instead of using constructor for injection.
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
		}

		public IEnumerable<Employee> Employees { get; set; }
	}
}
