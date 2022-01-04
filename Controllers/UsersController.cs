using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monopoly_Api.IRepositories;
using Monopoly_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repo;
        public UsersController(IUserRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("authentication/{user}/{password}")]
        public ActionResult<bool> checkAuthen(string user, string password)
        {
            return Ok(_repo.checkingAuthentication(user, password));
        }
        [HttpGet("{user}")]
        public ActionResult<User> getUser(string user)
        {
            return Ok(_repo.getUser(user));
        }
    }
}
