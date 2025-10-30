namespace _360_InventoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Supplier { get; set; } = string.Empty;
    }
}
