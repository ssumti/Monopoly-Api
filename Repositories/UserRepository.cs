using Monopoly_Api.Data;
using Monopoly_Api.IRepositories;
using Monopoly_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly_Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool checkingAuthentication(string user, string password)
        {
            FakeData data = new FakeData();
            var foundUsers = (from u in data.listOfUser
                              where (u.Username == user)
                              select u).ToList();
            if (!foundUsers.Any())
                return false;
            else
            {
                var checkUser = foundUsers.First();
                if (checkUser.Password == password)
                    return true;
                else
                    return false;
            }
        }
        public User getUser(string user)
        {
            FakeData data = new FakeData();
            var foundUsers = (from u in data.listOfUser
                              where (u.Username == user)
                              select u).ToList();
            return foundUsers.First();
        }
    }
}
