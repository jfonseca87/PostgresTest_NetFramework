using System.Data.Entity;

namespace ConsoleAppPostgresTest.Models
{
    public class PgContext : DbContext
    {
        public PgContext() : base("name=PgConn")
        { }

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}
