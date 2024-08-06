using System.ComponentModel.DataAnnotations;

namespace MinecraftHypixel.Models
{
    public class Item
    {
        public int? Price { get; set; }
        [Required(ErrorMessage = "Id is required")]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Material {get;set;}
        public string? Color { get; set; }
        public string? Category { get; set; }
        public string? Tier { get; set; }
        public string? Stats { get; set; }

        public Item()
        {
        }

        public Item(ItemView itemView)
        {
            Id = itemView.Id;
            Name = itemView.Name;
        }

    }
}
