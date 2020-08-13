using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities
{
    public class Tag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PartyRequestToTag> PartyRequestToTags { get; set; }

        public virtual ICollection<GameToTag> GamesToTags { get; set; }
    }
}
