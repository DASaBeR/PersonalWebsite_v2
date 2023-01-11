using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite_v2.Models.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "7b60d004-3d87-4b4d-9c0f-934e5d8fd1ba",
								Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "cf25c884-224c-498b-88ac-c87e947f6e1a"
						});

        }
    }
}