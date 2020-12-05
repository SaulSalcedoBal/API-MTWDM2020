using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_MTWDM101.Models;

namespace API_MTWDM101.Models
{
    /*
    public class UserMin
    {
        public int ID { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class User : UserMin
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public AccountType accountType { get; set; }
    }
    */
    public class User : DbContext
    {
        public User(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Login> LoginModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasData(new Login
            {
                Id = 1,
                UserName = "Balderas",
                Password = "pass"
            });
        }
    }

    public enum AccountType : int
    {
        Basic = 0,
        Administrator = 1,
    }
}
