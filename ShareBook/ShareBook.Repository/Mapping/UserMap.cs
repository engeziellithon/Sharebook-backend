﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShareBook.Domain;

namespace ShareBook.Repository.Mapping
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            entityBuilder.Property(t => t.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            entityBuilder.Property(t => t.Password)
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50)
                    .IsRequired();

            entityBuilder.Property(t => t.PasswordSalt)
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50)
                    .IsRequired();

            entityBuilder.Property(t => t.PostalCode)
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();

            entityBuilder.Property(t => t.Linkedin)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            entityBuilder.Property(t => t.Phone)
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

        }
    }
}
