using System.ComponentModel.DataAnnotations;

namespace MinecraftHypixel.Models
{
    public class Item : ItemView
    {
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
