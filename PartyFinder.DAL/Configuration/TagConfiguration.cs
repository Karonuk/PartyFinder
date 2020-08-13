using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.PartyRequestToTags)
                .WithOne(x => x.Tag)
                .HasForeignKey(x => x.TagId);
            builder.HasMany(x => x.GamesToTags)
                .WithOne(x => x.Tag)
                .HasForeignKey(x => x.TagId);
        }
    }
}
