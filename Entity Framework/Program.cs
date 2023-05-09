using System.ComponentModel.DataAnnotations;
using ef.Model;
using Microsoft.EntityFrameworkCore;

namespace ef {
    class Program {
        public static async Task createDatabase() {
            using (var context = new ShopContext()) {
                    bool res = await context.Database.EnsureCreatedAsync();
                    if (res) {
                        Console.WriteLine("Create success!");
                    } else {
                        Console.WriteLine("Create Failed!");
                    }
            }
        }

        public static async Task DropDatabase() {
            using (var context = new ShopContext()) {
                bool res = await context.Database.EnsureDeletedAsync();
                if (res) {
                    Console.WriteLine("Drop success!");
                } else {
                    Console.WriteLine("Drop Failed");
                }
            }
        }

        public static async Task InsertCatagory () {
            using var context = new ShopContext();
            await context.AddAsync(new Catagory(){Name = "Dien thoai", Description = "Cac loai dien thoai"});
            await context.AddAsync(new Catagory(){Name = "Nuoc ngot", Description = "Cac loai nuoc ngot"});
            await context.AddAsync(new Catagory(){Name = "Do an", Description = "Cac loai do an"});

            await context.AddRangeAsync(new Product[] {
                new Product { Name = "Iphone", Price = 1000, CatagoryId = 1 },
                new Product { Name = "Laptop", Price = 1100, CatagoryId = 1 },
                new Product { Name = "Pepsi", Price = 500, CatagoryId = 2 },
                new Product { Name = "Coca", Price = 800, CatagoryId = 2 },
                new Product { Name = "Beefsteak", Price = 700, CatagoryId = 3 },
                new Product { Name = "Mango", Price = 200, CatagoryId = 3 },
                new Product { Name = "Pho", Price = 600, CatagoryId = 3 }
            });

            await context.SaveChangesAsync();
        }

        public static async Task InsertProduct() {
            using var context = new ShopContext();
            await context.AddAsync(new Product { Name = ""});
        }

        // public static async Task createDatabase () {
        //     using (var dbContext = new ShopContext()) {
        //         try {
        //             string dbName = dbContext.Database.GetDbConnection().Database;

        //             bool result = await dbContext.Database.EnsureCreatedAsync();
        //             string resString = result ? "Created" : "Have already been created";
        //             Console.WriteLine($"{dbName}: {resString}");

        //         } catch (Exception e) {
        //             Console.WriteLine(e.Message);
        //         }
        //     }
        // }

        // public static async Task InsertRow(User user) {
        //     using (var context = new UserContext()){
        //         await context.user.AddAsync(user);

        //         int row = await context.SaveChangesAsync();
        //         Console.WriteLine($"Num rows have changed: {row}");
        //     }
        // }

        // public static async Task InsertManyRow(User[] rows) {
        //     using (var context = new UserContext()) {
        //         await context.user.AddRangeAsync(rows);

        //         int row = await context.SaveChangesAsync();
        //         Console.WriteLine($"Num rows have changed: {row}");
        //     }
        // }

        // public static async Task QueryData() {
        //     using (var context = new UserContext()) {
        //         await (from u in context.user
        //                 where !u.Email.Contains("Q")
        //                 select u).ForEachAsync(u => {
        //                     context.Remove(u);
        //                 });

        //         int row = await context.SaveChangesAsync();
        //         Console.WriteLine($"Num rows have changed: {row}");
        //     }
        // }

        public static async Task Main() {
            // await DropDatabase();
            // await createDatabase();
            await InsertCatagory();
        }
    }
}