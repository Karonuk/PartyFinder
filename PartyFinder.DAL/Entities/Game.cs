using PartyFinder.DAL.Entities.Profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities
{
    public class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string GameImage { get; set; }

        public virtual ICollection<PartyRequest> PartyRequests { get; set; }
        public virtual ICollection<GameToTag> GamesToTags { get; set; }
        public virtual ICollection<GameModeratorProfile> GameModeratorProfiles { get; set; }
    }
}
