using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class AdminProfileConfiguration : IEntityTypeConfiguration<AdminProfile>
    {
        public void Configure(EntityTypeBuilder<AdminProfile> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.BaseProfile)
                .WithOne(x => x.Admin)
                .HasForeignKey<AdminProfile>(x => x.Id);
        }
    }
}
