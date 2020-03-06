
using System.Data.Entity;

namespace CrmBl.Model
{
     public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnection") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProducts> CategoryProductsAll { get; set; }
        public DbSet<CurrentRate> CurrentRates { get; set; }
        public DbSet<Werehouse> Werehouses { get; set; }

    }
}
