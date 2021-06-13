using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Business
{
   public interface IUserService
    {
        User GetUser(string userName, string password);
    }
}
