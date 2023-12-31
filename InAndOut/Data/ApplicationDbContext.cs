﻿using InAndOut.Models;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace InAndOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
                                                
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses{ get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data
            modelBuilder.Entity<Item>().HasData(

                new Item { Id = 1, Borrower = "Akhilesh", ItemName="Toy", Lender="Bimal"},
                new Item { Id = 2, Borrower = "Harish", ItemName="Truck", Lender="Rajesh"},   
                new Item { Id = 3, Borrower = "Nitesh", ItemName = "Car", Lender = "Devanti" },
                new Item { Id = 5, Borrower = "Dhillon", ItemName = "Bike", Lender = "Hero" }
            );
        }         
    }
}
