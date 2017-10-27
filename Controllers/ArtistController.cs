
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Chinook.Models;
using System.Linq;

namespace Chinook.Controllers
{
  [Route ("api/[controller]")] public class ArtistController:Controller
  {
    private readonly ChinookContext _context;

    public ArtistController (ChinookContext context)
    {
      _context = context;
    }


    [HttpGet] public IEnumerable < Artist > GetAll ()
    {
      return _context.Artists.ToList ();
    }

  }
}
