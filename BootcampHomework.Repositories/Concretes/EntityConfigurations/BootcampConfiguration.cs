using BootcampHomework.Entities;
using BootcampHomework.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Repositories.Concretes.EntityConfigurations
{
    public class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
    {
        public void Configure(EntityTypeBuilder<Bootcamp> builder)
        {
            builder.ToTable("Bootcamps");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.InstructorId)
                .HasColumnName("InstructorId")
                .IsRequired();

            builder.Property(x => x.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            builder.Property(x => x.EndDate)
                .HasColumnName("EndDate");

            builder.Property(x => x.State)
                .HasColumnName("State")
                .HasDefaultValue(BootcampState.OPEN_FOR_APPLICATION)
                .IsRequired();
        }
    }
} 