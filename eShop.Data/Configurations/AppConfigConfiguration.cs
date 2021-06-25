using System;
using System.Collections.Generic;
using System.Text;
using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.Data.Configurations
{
    class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");//Tên bảng

            builder.HasKey(x => x.Key);//Khóa chính

            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
