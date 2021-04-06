using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Data
{
    /// <summary>
    /// Class that configures database connection and contains all DbSets used in database
    /// </summary>
    class DataContext : DbContext
    {
        /// <summary>
        /// Sets connection with database
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // The path needs to be changed when project is in different directory
            optionsBuilder.UseSqlite(@"Data Source=C:/Users/Maciej/Desktop/Metapackv2/Pizzeria/Pizzeria/pizzeriaDatabase.db");
        }

        /// <summary>
        /// DbSet of Additions
        /// </summary>
        public DbSet<Addition> Additions { get; set; }

        /// <summary>
        /// DbSet of Food
        /// </summary>
        public DbSet<Food> Food { get; set; }

        /// <summary>
        /// DbSet of FoodCategories
        /// </summary>
        public DbSet<FoodCategory> FoodCategories { get; set; }

        /// <summary>
        /// DbSet of FoodOrders
        /// </summary>
        public DbSet<FoodOrder> FoodOrders { get; set; }

        /// <summary>
        /// DbSet of Orders
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// DbSet of AdditionOrders
        /// </summary>
        public DbSet<AdditionOrder> AdditionOrders { get; set; }
    }
}
