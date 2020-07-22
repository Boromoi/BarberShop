using BarberShop.Domain;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Data
{
    public class BarberShopContext:DbContext
    {
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public BarberShopContext() : base()
        { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="options"></param>
        public BarberShopContext(DbContextOptions<BarberShopContext> options)
            : base(options)
        { }

        public DbSet<HairStyle> Hairs { get; set; }
        public DbSet<Prices> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = BarberShopAppData; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HairStylePrices>()
                .HasKey(s => new { s.HairStyleId, s.PricesId });
        }
    }
}
