using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.GameModeratorProfiles)
                .WithOne(x => x.Game)
                .HasForeignKey(x => x.GameId);
            builder.HasMany(x => x.GamesToTags)
                .WithOne(x => x.Game)
                .HasForeignKey(x => x.GameId);
            builder.HasMany(x => x.PartyRequests)
                .WithOne(x => x.Game)
                .HasForeignKey(x => x.GameId);                
        }
    }
}
