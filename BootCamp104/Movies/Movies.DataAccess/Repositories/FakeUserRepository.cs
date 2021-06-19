using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Movies.DataAccess.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }


        private List<User> users = new List<User>
           {
               new User { Email="abc@xxx.com", Password="123", UserName="turkay", Role="Admin"},
               new User { Email="def@xxx.com", Password="987", UserName="mahmut", Role="Editor"},
               new User { Email = "zxc@xxx.com", Password = "666", UserName="irem", Role="User" },


           };
        public IList<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetWithCriteria(Func<User, bool> criteria)
        {
            return users.Where(criteria).ToList();
        }
               

       

        public User Update(User genre)
        {
            throw new NotImplementedException();
        }
    }
}
