﻿using EFChallenge.Data.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFChallenge.Data.Configurations
{
    internal class AddressTypeConfig : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> entity)
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.HasData(new AddressType
            {
                Id = 1,
                Name = "Physical Address"
            });
            entity.HasData(new AddressType
            {
                Id = 2,
                Name = "IRS Address"
            });
        }
    }
}
