using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.IdOrder);
            builder.Property(e => e.IdOrder).ValueGeneratedOnAdd();
            builder.Property(e => e.Notes).HasMaxLength(255);
            builder.Property(e => e.IdEmployee).IsRequired(false);
            builder.ToTable("Orders");

            builder.HasMany(order => order.Confectionary_Orders)
                   .WithOne(conficOrder => conficOrder.Order)
                   .HasForeignKey(conficOrder => conficOrder.IdOrder)
                   .IsRequired();

        }
    }

}
