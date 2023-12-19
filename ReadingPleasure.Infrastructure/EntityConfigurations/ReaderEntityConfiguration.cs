﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReadingPleasure.Domain.Entities;

namespace ReadingPleasure.Infrastructure.EntityConfigurations
{
    public class ReaderEntityConfiguration : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> builder)
        {
            builder.ToTable("readers");

            builder
                .Property(c => c.Id)
                .HasColumnName("id");

            builder.HasKey(b => b.Id);

            builder
                .Property(x => x.WordsPerMinute)
                .IsRequired()
                .HasColumnName("words_per_minute");

            builder
                .Property(s => s.UserId)
                .HasColumnName("user_id");

            builder
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(s => s.Sex)
                .HasColumnName("sex")
                .HasMaxLength(1)
                .HasColumnType("varchar(1)")
                .HasConversion<string>()
                .IsRequired();
        }
    }
}