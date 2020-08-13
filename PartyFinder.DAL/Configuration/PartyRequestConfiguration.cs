using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class PartyRequestConfiguration : IEntityTypeConfiguration<PartyRequest>
    {
        public void Configure(EntityTypeBuilder<PartyRequest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.PartyRequestToTags)
                .WithOne(x => x.PartyRequest)
                .HasForeignKey(x => x.PartyRequestId);
            builder.HasOne(x => x.Game)
                .WithMany(x => x.PartyRequests)
                .HasForeignKey(x => x.GameId);

        }
    }
}
