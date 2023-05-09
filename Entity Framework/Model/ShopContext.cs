using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ef.Model {
    class ShopContext : DbContext {

        public DbSet<Product> products {get; set;}

        private readonly string sqlString = @"Server=localhost;
                                            Database=Shop;
                                            UID=sa;PWD=Password123;
                                            Encrypt=false";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            ILoggerFactory logger = LoggerFactory.Create(builder => {
                builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
                    .AddConsole();
            });

            optionsBuilder.UseSqlServer(sqlString)
                          .UseLoggerFactory(logger);

        }
    }
}