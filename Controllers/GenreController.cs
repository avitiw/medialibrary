
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chinook.Models;
using System.Linq;

namespace Chinook.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private readonly ChinookContext _context;

        public GenreController(ChinookContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }

    }
}
