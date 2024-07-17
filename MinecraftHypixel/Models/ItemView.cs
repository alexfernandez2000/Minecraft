using System.ComponentModel.DataAnnotations;

namespace MinecraftHypixel.Models
{
    public class ItemView
    {
        [Required(ErrorMessage = "Id is required")]
        public string? Id { get; set; }
        public string? Name { get; set; }


    }
}
