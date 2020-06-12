using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(e => e.IdClient);
            builder.Property(e => e.IdClient).ValueGeneratedOnAdd();
            builder.Property(e => e.FName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.LName).HasMaxLength(60).IsRequired();
            builder.ToTable("Customer");

            builder.HasMany(emp => emp.Orders)
                      .WithOne(order => order.Customer)
                      .HasForeignKey(order => order.IdClient)
                      .IsRequired();

        }
    }
}
