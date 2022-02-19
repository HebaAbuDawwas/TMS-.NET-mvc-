using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Models.ViewModels
{
    public class FindProject
    {
        public string Name { get; set; }
        public eSize Size { get; set; } = eSize.Normal;
        public IEnumerable<Project> Projects { get; set; }

    }
}
