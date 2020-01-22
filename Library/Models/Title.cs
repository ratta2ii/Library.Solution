using System.Collections.Generic;

namespace Library.Models
{
    public class Title
    {
        public int TitleId { get; set; }

        public string TitleName { get; set; }
        
        public virtual ICollection<Book> Authors { get; set; }

        public Title()
        {
            this.Authors = new HashSet<Book>();
        }
    }
}