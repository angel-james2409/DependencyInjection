using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MyDependency : IMyDependency
    {

        //Console.WriteLine("MyDependency.Write Message:{message}");
        public void WriteMessage(string message)
        {
            Console.WriteLine("MyDependency.Write Message:{message}");
            throw new NotImplementedException();
        }
    }
}
