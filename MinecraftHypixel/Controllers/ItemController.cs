using MinecraftHypixel.Models;

namespace MinecraftHypixel.Controllers
{
    public class ItemController
    {
        public ItemController()
        {
            
        }
        public async Task<IEnumerable<Item>?> GetItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Id="ID",Material="DIAMENTE",Name="DIAMENTE",Category="MINERAL",Color="AZUL",Stats="OK",Tier="SEMIGOD"});
            items.Add(new Item() { Id = "ID2", Material = "DIAMENTE", Name = "DIAMENTE", Category = "MINERAL", Color = "AZUL", Stats = "OK", Tier = "SEMIGOD" });
            items.Add(new Item() { Id = "ID3", Material = "DIAMENTE", Name = "DIAMENTE", Category = "MINERAL", Color = "AZUL", Stats = "OK", Tier = "SEMIGOD" });

            return items;
        }
    }
}
