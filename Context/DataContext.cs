using Microsoft.EntityFrameworkCore;
using TestTaskQulix.Models;

namespace TestTaskQulix.Context
{   
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            /*Database.EnsureDeleted();*/
            Database.EnsureCreated();

        }
        
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Text> Texts { get; set; }
    }
     
}
