using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product {
                    Id=2,
                    Name="Daxtors",
                    Description="Her türlü spor ayakkabı",
                    Price=107,
                    Discount=0.25f,
                    ImageUrl="www.trendtol.com/images/resim1.jpg",
                    IsActive=true,
                    Stock=1000,
                    CreatedDate = DateTime.Now
                },

                new Product {
                    Id=3,
                    Name="Adidas",
                    Description="......",
                    Price=250,
                    Discount=0.23f,
                    ImageUrl="www.trendtol.com/images/resim1.jpg",
                    IsActive=false,
                    Stock=2000,
                    CreatedDate = new DateTime(2021,1,1)
                }
            };

            products.Add(new Product
            {
                Id = 1,
                Name = "Solante",
                Description = "Pigmenta Koyu Lekelere Karşı Güneş Losyonu Spf 50+ 150 ml",
                Price = 100.25M,
                Discount = 0.15f,
                IsActive = true,
                Stock = 1300,
                CreatedDate = new DateTime(2021, 4, 10)
            });

            return products;
        }
    }
}
