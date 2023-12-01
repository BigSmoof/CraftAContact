﻿using CraftAContact.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CraftAContact.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Added Dbsets for Contact and Category classes
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Overriding the onModelCreating function in order to add seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family"},
                new Category { CategoryId = 2, CategoryName = "Friends"},
                new Category { CategoryId = 3, CategoryName = "Work"},
                new Category { CategoryId = 4, CategoryName = "Other"}
                );

            // Seed data for Contacts
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Email = "imBatman222@gmail.com",
                    PhoneNumber = 5066885555,
                    DateCreated = "2023-11-29",
                    CategoryId = 2,
                    Username = "Biggy1"
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Goro",
                    LastName = "Majima",
                    Email = "kiryuChan23@msn.com",
                    PhoneNumber = 5064779584,
                    DateCreated = "2023-11-24",
                    CategoryId = 1,
                    Username = "Biggy1"
                }
                );
        }
    }

}
