using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace migration.Model {
    public class WebContext : DbContext 
    {
        public DbSet<Article> Articles {get; set;}
        public DbSet<Tag> Tags {get; set;}


        private readonly string _connectionString = @"Server=localhost;
                                                      Database=webdb;
                                                      UID=sa;PWD=Password123;
                                                      Encrypt=false";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            ILoggerFactory logger = LoggerFactory.Create(config => {
                config
                    .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                    .AddConsole();
            });
            optionsBuilder.UseSqlServer(_connectionString)
                          .UseLoggerFactory(logger);
        }
    }
}