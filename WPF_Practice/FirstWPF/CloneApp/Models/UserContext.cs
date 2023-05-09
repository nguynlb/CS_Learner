using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneApp.Models
{
    public class UserContext : DbContext
    {

        public DbSet<UserModel> User { get; set; } 

        private string _connectionString = "Server:localhost;Database:UserDB;UID:sa;PWD:Password123";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
