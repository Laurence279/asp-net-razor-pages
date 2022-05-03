using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class MagicItem {
        
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Rarity { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Cost { get; set; }


    }
}