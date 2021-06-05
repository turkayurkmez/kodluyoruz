using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Models
{
   public interface IGuidGenerator
    {
         Guid GeneratedGuid { get; set; }

          
    }

    public interface IScopedGenerator: IGuidGenerator
    {

    }

    public interface ISingletonGenerator:IGuidGenerator
    {

    }

    public interface ITransientGenerator:IGuidGenerator
    {

    }
}
