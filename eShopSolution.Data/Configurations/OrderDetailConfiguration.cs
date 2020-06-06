using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(t => t.Order).WithMany(pc => pc.OrderDetails).HasForeignKey(pc => pc.OrderId);
            builder.HasOne(t => t.Product).WithMany(pc => pc.OrderDetails).HasForeignKey(pc => pc.OrderId);
        }
    }
}
