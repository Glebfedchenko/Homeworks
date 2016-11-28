namespace CF.Store
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreDB : DbContext
    {
        public StoreDB()
            : base("name=Store")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().MapToStoredProcedures();
            modelBuilder.Entity<Sale>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
