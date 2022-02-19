using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models.ViewModels
{
    public class ProjectSummary
    {
        //FindBy
        public string Name { get; set; }


        //Result
        //جاي بالفاينل والله والله واللهي 
        public IEnumerable<Project> Projects { get; set; }



    }
}
