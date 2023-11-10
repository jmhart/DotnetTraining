using Microsoft.EntityFrameworkCore;
using Infra.Data;

namespace Unit.Infra.Data
{
    public class InMemoryDatabaseTests
    {
        [Fact]
        public async Task CanInsertIntoDatabase()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ExampleDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Act
            using (var context = new ExampleDbContext(options))
            {
                var entity = new ExampleEntity
                {
                    Name = "Name"
                };
                context.ExampleEntities.Add(entity);
                await context.SaveChangesAsync();
            }

            // Assert
            using (var context = new ExampleDbContext(options))
            {
                Assert.Equal(1, await context.ExampleEntities.CountAsync());
            }
        }
    }
}