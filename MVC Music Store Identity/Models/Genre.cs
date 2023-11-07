using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Music_Store_Identity.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}