using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class PartyRequestToTagConfiguration : IEntityTypeConfiguration<PartyRequestToTag>
    {
        public void Configure(EntityTypeBuilder<PartyRequestToTag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PartyRequest)
                .WithMany(x => x.PartyRequestToTags)
                .HasForeignKey(x => x.PartyRequestId);
            builder.HasOne(x => x.Tag)
                .WithMany(x => x.PartyRequestToTags)
                .HasForeignKey(x => x.TagId);
        }
    }
}
