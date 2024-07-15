namespace MinecraftHypixel.Models
{
    public class Item
    {
        public required string  Id { get; set; }
        public string? Material {get;set;}
        public string? Color { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Tier { get; set; }
        public string? Stats { get; set; }

    }
}
