﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    interface IOperation
    {
        string OperationId { get; }
        public interface IOperationTransient : IOperation { }
        public interface IOperationScoped : IOperation { }
        public interface IOperationSingleton : IOperation { }
    }
}
