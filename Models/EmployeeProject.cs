using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models
{
    public class EmployeeProject
    {
        [Key]
        public int EmployeeProjectId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public eStatus Status { get; set; }
        //Navigation
        public Employee Employee { get; set; }
        public Project Project { get; set; }


    }
}
