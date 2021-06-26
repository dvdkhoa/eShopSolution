using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new { Key = "EshopTitle", Value = "This is Eshop Tittle" },
                new { Key = "EshopKey", Value = "This is Eshop Key Word" },
                new { Key = "EshopDes", Value = "This is Eshop Description" });


        }
    }
}
