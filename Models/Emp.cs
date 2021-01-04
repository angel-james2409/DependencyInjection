using DependencyInjection.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Emp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        internal static IEnumerable<EmpController> Get()
        {
            throw new NotImplementedException();
        }
    }
}
