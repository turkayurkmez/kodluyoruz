using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Models
{
    public abstract class GuidGeneratorBase
    {
        public Guid GeneratedGuid { get ; set; }
        public GuidGeneratorBase()
        {
            GeneratedGuid = Guid.NewGuid();
        }


    }
}
