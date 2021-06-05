using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCforLifeCycle.Models
{
    public class TransientGuidGenerator: GuidGeneratorBase, ITransientGenerator
    {
    }
}
