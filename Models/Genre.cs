
using System;using System.ComponentModel.DataAnnotations.Schema;
namespace Chinook.Models
{
   [Table("Genre")]
  public class Genre
  {
    public string Name
    {
      get;
      set;
    }
    public int GenreId
    {
      get;
      set;
    }
  }
}
