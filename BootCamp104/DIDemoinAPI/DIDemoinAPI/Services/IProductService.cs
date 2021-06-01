using DIDemoinAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Services
{
   public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
