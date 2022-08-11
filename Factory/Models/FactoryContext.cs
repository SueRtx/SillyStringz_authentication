// using Microsoft.EntityFrameworkCore;

// namespace Factory.Models
// {
//   public class FactoryContext : DbContext
//   {
//     public DbSet<Category> Categories { get; set; }
//     public DbSet<Item> Items { get; set; }
//     public DbSet<CategoryItem> CategoryItem { get; set; }

//     public FactoryContext(DbContextOptions options) : base(options) { }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//       optionsBuilder.UseLazyLoadingProxies();
//     }
//   }
// }