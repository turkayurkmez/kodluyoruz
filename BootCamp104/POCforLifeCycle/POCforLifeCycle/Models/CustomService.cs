using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Models
{
    public class CustomService
    {
        public CustomService(IScopedGenerator scoped, ISingletonGenerator singleton, ITransientGenerator transient )
        {
            ScopedGuid = scoped.GeneratedGuid;
            SingletonGuid = singleton.GeneratedGuid;
            TransientGuid = transient.GeneratedGuid;

        }

        public Guid ScopedGuid { get; set; }
        public Guid SingletonGuid { get; set; }
        public Guid TransientGuid { get; set; }

    }
}
