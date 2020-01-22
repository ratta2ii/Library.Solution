namespace Library.Models
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public int PatronId { get; set; }
        public int InventoryId { get; set; }
        public string Date { get; set; } // Date = DateTime.Now.ToString("MM-dd-yyyy");
        public Patron Patron { get; set; }
        public Inventory Inventory { get; set; }
    }
} 