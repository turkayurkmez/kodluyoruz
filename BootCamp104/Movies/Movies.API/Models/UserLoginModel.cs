using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Models
{
    public class UserLoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
