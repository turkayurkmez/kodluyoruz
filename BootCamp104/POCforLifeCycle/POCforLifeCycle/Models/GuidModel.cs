using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Models
{
    public class GuidModel
    {
        public Guid ScopedGuid { get; set; }
        public Guid SingletonGuid { get; set; }
        public Guid TransientGuid { get; set; }

        public Guid ScopedServiceGuid { get; set; }
        public Guid SingletonServiceGuid { get; set; }
        public Guid TransientServiceGuid { get; set; }

    }
}
