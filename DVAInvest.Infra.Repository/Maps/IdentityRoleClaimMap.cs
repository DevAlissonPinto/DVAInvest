﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Maps;

public class IdentityRoleClaimMap : IEntityTypeConfiguration<IdentityRoleClaim<long>>
{
    public void Configure(EntityTypeBuilder<IdentityRoleClaim<long>> builder)
    {
        builder.ToTable("IdentityRoleClaim");
        builder.HasKey(rc => rc.Id);
        builder.Property(u => u.ClaimType).HasMaxLength(255);
        builder.Property(u => u.ClaimValue).HasMaxLength(255);
    }
}
