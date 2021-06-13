using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models
{
   public class User : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
