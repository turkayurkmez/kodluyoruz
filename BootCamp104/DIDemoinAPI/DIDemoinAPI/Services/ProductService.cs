using DIDemoinAPI.Data;
using DIDemoinAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Services
{
    public class ProductService : IProductService
    {
        private MiniDbContext miniDbContext;

        public ProductService(MiniDbContext miniDbContext)
        {
            this.miniDbContext = miniDbContext;
        }
        public IList<Product> GetProducts()
        {
            return miniDbContext.Products.ToList();
        }
    }
}
