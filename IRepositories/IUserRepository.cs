using Monopoly_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly_Api.IRepositories
{
    public interface IUserRepository
    {
        bool checkingAuthentication(string user, string password);
        User getUser(string user);
    }
}
