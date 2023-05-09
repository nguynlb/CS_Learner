using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ef.Entity {
    class UserContext : DbContext
    {
        public DbSet<User> user {get; set;}

        private readonly ILoggerFactory logger = LoggerFactory.Create(builder => {
            builder
                .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
                .AddConsole();
        });

        // Cau hinh cho DbContext => Ket noi den Database Server
        private string sqlConnection = @"Server=localhost;
                                         Database=UserInfo;
                                         UID=SA;PWD=Password123;
                                         Encrypt=false";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(logger)
                .UseSqlServer(sqlConnection);
        }

        

    }
}