using BannerflowBanner.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BannerflowBanner.Data.Context
{
    public class BannerflowContext : DbContext
    {
        public DbSet<Banner> Banners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //InMemoryDatabase
            optionsBuilder.UseInMemoryDatabase(databaseName: "BannerDB");
        }
    }
}
