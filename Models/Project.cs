using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public eSize Size { get; set; } = eSize.Normal;
        public byte[] Icon { get; set; } = Array.Empty<byte>();
        //Navigation
        public ICollection<EmployeeProject> Employeeprojects { get; set; }
    }
}
