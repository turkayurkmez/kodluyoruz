using DIDemoinAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Services
{
    public class FakeProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            return new List<Product>
           {
               new Product{ Id =1, Name="A", Price=100},
               new Product{ Id =2, Name="B", Price=150},
               new Product{ Id =3, Name="C", Price=75},
           };
        }
    }
}
