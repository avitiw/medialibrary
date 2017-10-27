
using Microsoft.EntityFrameworkCore;

namespace Chinook.Models
{
  public class ChinookContext:DbContext
  {
    public ChinookContext (DbContextOptions < ChinookContext >
			   options):base (options)
    {

    }
    public DbSet < User > Users
    {
      get;
      set;
    }
    public DbSet < Album > Albums
    {
      get;
      set;
    }
    public DbSet < Artist > Artists
    {
      get;
      set;
    }
    public DbSet < Genre > Genres
    {
      get;
      set;
    }
    public DbSet < Track > Tracks
    {
      get;
      set;
    }
  }
}
