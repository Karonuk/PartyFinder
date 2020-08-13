using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class GameToTagConfiguration : IEntityTypeConfiguration<GameToTag>
    {
        public void Configure(EntityTypeBuilder<GameToTag> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.Game)
                .WithMany(x => x.GamesToTags)
                .HasForeignKey(x => x.GameId);
            builder.HasOne(x => x.Tag)
                .WithMany(x => x.GamesToTags)
                .HasForeignKey(x => x.TagId);
        }
    }
}
