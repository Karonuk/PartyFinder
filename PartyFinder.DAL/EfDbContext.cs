using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PartyFinder.DAL.Entities;
using PartyFinder.DAL.Entities.Profiles;
using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL
{
    public class EfDbContext: IdentityDbContext<IdentityUser, IdentityRole, string, IdentityUserClaim<string>,
    IdentityUserRole<string>, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
        }
        
        public DbSet<AdminProfile> AdminProfiles { get; set; }
        public DbSet<BaseProfile> BaseProfiles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameModeratorProfile> GameModeratorProfiles { get; set; }
        public DbSet<GameToTag> GameToTags { get; set; }
        public DbSet<PartyRequest> PartyRequests { get; set; }
        public DbSet<PartyRequestToTag> PartyRequestToTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDbContext).Assembly);
        }
    }
}
