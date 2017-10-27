
using System;using System.ComponentModel.DataAnnotations.Schema;
namespace Chinook.Models
{ 
  [Table("Track")]
  public class Track
  {
    public string Name
    {
      get;
      set;
    }
    public string Composer
    {
      get;
      set;
    }
    public int AlbumId
    {
      get;
      set;
    }
    public int GenreId
    {
      get;
      set;
    }
    public int Milliseconds
    {
      get;
      set;
    }
    public int TrackId
    {
      get;
      set;
    }
  }
}
