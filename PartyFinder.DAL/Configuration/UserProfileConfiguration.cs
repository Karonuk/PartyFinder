using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BaseProfile)
                .WithOne(x => x.User)
                .HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
