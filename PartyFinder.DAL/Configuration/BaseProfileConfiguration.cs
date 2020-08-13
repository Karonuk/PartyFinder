using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class BaseProfileConfiguration : IEntityTypeConfiguration<BaseProfile>
    {
        public void Configure(EntityTypeBuilder<BaseProfile> builder)
        {
            builder.HasMany(x => x.PartyRequests)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}
