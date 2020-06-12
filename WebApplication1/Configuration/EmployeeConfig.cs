using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class EmployeeConfig : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
            
            builder.HasKey(e => e.IdEmployee);
            builder.Property(e => e.IdEmployee).ValueGeneratedOnAdd();
            builder.Property(e => e.FName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.LName).HasMaxLength(60).IsRequired();
            builder.ToTable("Employee");

            builder.HasMany(emp => emp.Orders)
                      .WithOne(order => order.Employee)
                      .HasForeignKey(order => order.IdEmployee)
                      .IsRequired();
           
        }
	}
}
