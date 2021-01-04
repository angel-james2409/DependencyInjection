using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DependencyInjection.Models.IOperation;

namespace DependencyInjection.Models
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public string OperationId => throw new NotImplementedException();
    }
}
