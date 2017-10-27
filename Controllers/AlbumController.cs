
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chinook.Models;
using System.Linq;

namespace Chinook.Controllers
{
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {
        private readonly ChinookContext _context;

        public AlbumController(ChinookContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Album> GetAll()
        {
            return _context.Albums.ToList();
        }

    }
}
