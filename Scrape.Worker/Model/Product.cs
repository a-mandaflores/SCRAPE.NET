using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrapeAPI.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        [Column("title")]
        public string title { get; set; } = string.Empty;
        [Column("description")]
        public string description { get; set; } = string.Empty ;
        [Column("image_url")]
        public string imageUrl { get; set; } = string.Empty;
        [Column("price")]
        public double price { get; set; } = default;
    }
}
