using System.Collections.Generic;

namespace Library.Models
{
    public class Patron
    {
        public int PatronId { get; set; }
        public string PatronName { get; set; }
        public virtual ICollection<Checkout> Inventories { get; set; }

        public Patron()
        {
            this.Inventories = new HashSet<Checkout>();
        }
    }
}





