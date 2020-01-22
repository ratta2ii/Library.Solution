using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : DbContext
  {
    public virtual DbSet<Title> Titles { get; set; }
    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Inventory> Inventories { get; set; }
    public virtual DbSet<Patron> Patrons { get; set; }
    public virtual DbSet<Checkout> CheckoutTable { get; set; }
    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}