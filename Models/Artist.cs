
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Chinook.Models
{
    [Table("Artist")]
    public class Artist
    {
        public string Name
        {
            get;
            set;
        }
        public int ArtistId
        {
            get;
            set;
        }
    }
}
