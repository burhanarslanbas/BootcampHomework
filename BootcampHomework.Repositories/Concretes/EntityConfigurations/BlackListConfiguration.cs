using BootcampHomework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Repositories.Concretes.EntityConfigurations
{
    public class BlackListConfiguration : IEntityTypeConfiguration<BlackList>
    {
        public void Configure(EntityTypeBuilder<BlackList> builder)
        {
            builder.ToTable("BlackLists");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(x => x.ApplicantId)
                .HasColumnName("ApplicantId")
                .IsRequired();

            builder.Property(x => x.Reason)
                .HasColumnName("Reason")
                .HasMaxLength(500);

            builder.Property(x => x.Date)
                .HasColumnName("Date")
                .IsRequired();
        }
    }
} 