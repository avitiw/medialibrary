
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chinook.Models;
using System.Linq;

namespace Chinook.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ChinookContext _context;

        public UserController(ChinookContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

    }
}
