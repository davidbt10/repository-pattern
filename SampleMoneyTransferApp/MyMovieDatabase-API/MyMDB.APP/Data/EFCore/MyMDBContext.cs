using Microsoft.EntityFrameworkCore;
using MyMDB.APP.Models;

namespace MyMDB.APP.Data.EFCore
{
    public class MyMDBContext : DbContext
    {
        public MyMDBContext (DbContextOptions<MyMDBContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Star> Star { get; set; }
    }
}
