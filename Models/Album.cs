
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chinook.Models
{
    [Table("Album")]
    public class Album
    {
        public string Title
        {
            get;
            set;
        }
        public int AlbumId
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
