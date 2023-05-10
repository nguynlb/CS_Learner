using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ef.Model {
    class ShopContext : DbContext {

        public DbSet<Product> Products {get; set;}

        public DbSet<Catagory> Catagories {get; set;}
        public DbSet<CatagoryDetail> CatagoryDetails {get; set;}
        
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


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity => {

                // Entity Configuration
                entity.ToTable("Product");

                // Property Configuration
                // PK
                entity.HasKey(p => p.Id);

                // Index
                entity.HasIndex(p => p.Price)
                      .HasDatabaseName("Product-Index");

                // Foreign Key
                entity.HasOne(p => p.Catagory)
                      .WithMany()
                      .OnDelete(DeleteBehavior.Cascade)
                      .HasForeignKey("CatagoryId");

                entity.HasOne(p => p.Catagory1)
                      .WithMany(c => c.Products)  // Collection navigation
                      .OnDelete(DeleteBehavior.NoAction)
                      .HasForeignKey("CatagoryId1");
            });

            modelBuilder.Entity<CatagoryDetail>(entity => {
                entity.HasOne(cd => cd.Catagory)
                      .WithOne(c => c.CategoryDetail)
                      .HasForeignKey<Catagory>(c => c.Id) // Specify a foreign key
                                                          // of a type CatogoryDetail or
                                                          // Catagory
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }


    }
}