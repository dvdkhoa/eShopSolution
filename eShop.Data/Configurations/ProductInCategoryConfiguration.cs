using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId }); //Khóa chính 

            builder.ToTable("ProductInCategory");

            //Cấu hình khóa ngoại cho 2 bảng (Category và Product)
            builder.HasOne(x => x.Category)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(f => f.CategoryId);

            builder.HasOne(x => x.Product)
                   .WithMany(t => t.ProductInCategories)
                   .HasForeignKey(f => f.ProductId);
        }
    }
}
