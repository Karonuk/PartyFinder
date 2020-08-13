using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities
{
    public class PartyRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public long GameId { get; set; }
        public string UserId { get; set; }

        public virtual BaseProfile User { get; set; }
        public virtual Game Game { get; set; }
        public virtual ICollection<PartyRequestToTag> PartyRequestToTags { get; set; }
    }
}
