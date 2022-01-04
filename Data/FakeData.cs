using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monopoly_Api.Models;

namespace Monopoly_Api.Data
{
    public class FakeData
    {
        public List<User> listOfUser = new List<User>();
        public FakeData()
        {
            listOfUser.Add(new User()
            {
                Username = "ssumti",
                Password="123456",
                Avatar = "Resources/dog.jpg"
            });
            listOfUser.Add(new User()
            {
                Username = "zzumti",
                Password = "123456",
                Avatar = "Resources/cat.jpg"
            });
            listOfUser.Add(new User()
            {
                Username = "ddumti",
                Password = "123456",
                Avatar = "Resources/duck.jpg"
            });
            listOfUser.Add(new User()
            {
                Username = "xxumti",
                Password = "123456",
                Avatar = "Resources/panda.jpg"
            });
        }
    }
}
