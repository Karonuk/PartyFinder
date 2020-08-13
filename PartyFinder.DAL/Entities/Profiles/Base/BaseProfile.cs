using PartyFinder.DAL.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities.Profiles.Base
{
    public class BaseProfile
    {
        [Key, ForeignKey("DbUser")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string NickName { get; set; }
        public string ImageUrl { get; set; }

        public virtual AdminProfile Admin { get; set; }
        public virtual GameModeratorProfile GameModerator { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual DbUser DbUser { get; set; }

        public virtual ICollection<PartyRequest> PartyRequests { get; set; }
    }
}
