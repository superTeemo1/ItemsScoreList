using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GRMTestApp.Models;

    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<GRMTestApp.Models.Item> Item { get; set; } = default!;
        public DbSet<GRMTestApp.Models.Match> Match { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                  new Item() { ItemID = 1, Name = "Item1", Position = 1, Score = 0, Value = 0 },
                  new Item() { ItemID = 2, Name = "Item2", Position = 2, Score = 0, Value = 0 },
                  new Item() { ItemID = 3, Name = "Item3", Position = 3, Score = 0, Value = 0 },
                  new Item() { ItemID = 4, Name = "Item4", Position = 4, Score = 0, Value = 0 },
                  new Item() { ItemID = 5, Name = "Item5", Position = 5, Score = 0, Value = 0 },
                  new Item() { ItemID = 6, Name = "Item6", Position = 6, Score = 0, Value = 0 });
        }
}
