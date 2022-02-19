using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models.ViewModels
{
    public class EmployeeSummary
    {
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
