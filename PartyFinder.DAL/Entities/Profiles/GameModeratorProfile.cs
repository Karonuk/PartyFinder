using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities.Profiles
{
    public class GameModeratorProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public long GameId { get; set; }

        public virtual BaseProfile BaseProfile { get; set; }
        public virtual Game Game { get; set; }
    }
}
