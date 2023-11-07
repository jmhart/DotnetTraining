using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
        {
        }

        public DbSet<ExampleEntity> ExampleEntities { get; set; }
    }

    public class ExampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}