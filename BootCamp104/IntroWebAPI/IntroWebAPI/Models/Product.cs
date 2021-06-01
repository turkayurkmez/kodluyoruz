using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }


        //Aiağıdakiler daha ayrıntı ya da kullanıcının bilmesine gereken olmayan (ama bizim tutmamız gereken) verileri görüyoruz
        public List<string> Properties { get; set; }
        public List<string> Colors { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }



    }
}
