using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MVC_Music_Store_Identity.Models
{

    public class Album
    {
        public int AlbumId { get; set; }
        [Required]
        public int GenreId { get; set; }

        [Required]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required]

        [Range(0.00, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}