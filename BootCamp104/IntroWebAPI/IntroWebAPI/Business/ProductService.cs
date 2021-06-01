using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductService
    {
        //Bir yerleden (mesela db) veriyi alacak olan sınıf.....
        public List<ProductListResponseDTO> GetListResponseDTOs()
        {

            ProductRepository repo = new ProductRepository();
            var products = repo.GetAllProducts();


            List<ProductListResponseDTO> dtoList = new List<ProductListResponseDTO>();

            foreach (var product in products)
            {
                var dto = new ProductListResponseDTO
                {
                    Description = product.Description,
                    Discount = product.Discount,
                    Id = product.Id,
                    ImageUrl = product.ImageUrl,
                    Name = product.Name,
                    Price = product.Price,
                    Rating = product.Rating
                };
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public Product GetProductResponseDto(int id)
        {
            ProductRepository repo = new ProductRepository();
            var products = repo.GetAllProducts();
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
