
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chinook.Models;
using System.Linq;

namespace Chinook.Controllers
{
    [Route("api/[controller]")]
    public class TrackController : Controller
    {
        private readonly ChinookContext _context;

        public TrackController(ChinookContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Track> GetAll()
        {
            return _context.Tracks.ToList();
        }

    }
}
