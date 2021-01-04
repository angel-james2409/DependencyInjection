﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MyEmp : IEmp
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine("MyEmp.Write Message:{message}");
            throw new NotImplementedException();
        }
    }
}
