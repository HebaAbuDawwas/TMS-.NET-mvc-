using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double FeesPerDay { get; set; }

        public string Photo { get; set; } = "userprofile.png";

        //Navigation
        public ICollection<EmployeeProject> Employeeprojects { get; set; }

    }
}
