using System.Collections.Generic;


namespace Library.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int CopiesAvailable { get; set; }
        public bool Available { get; set; }
        public virtual ICollection<Checkout> Patrons { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Inventory()
        {
            this.Patrons = new HashSet<Checkout>();
            this.Books = new HashSet<Book>();
        }

    }
}
