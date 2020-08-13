using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PartyFinder.DAL.Entities.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Configuration
{
    public class GameModeratorProfileConfiguration : IEntityTypeConfiguration<GameModeratorProfile>
    {
        public void Configure(EntityTypeBuilder<GameModeratorProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BaseProfile)
                .WithOne(x => x.GameModerator)
                .HasForeignKey<GameModeratorProfile>(x => x.Id);
            builder.HasOne(x => x.Game)
                .WithMany(x => x.GameModeratorProfiles)
                .HasForeignKey(x => x.GameId);
        }
    }
}
