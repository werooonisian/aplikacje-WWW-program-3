using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace aplikacje_WWW_zad_5.Models
{
    public class Product
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Maker { get; set; }
        [JsonPropertyName("img")] //tak nazywa się nasza zmienna w pliku
        public string Image { get; set; }
        public string Url { get; set; }
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
