using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities
{
    public class PartyRequestToTag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public long TagId { get; set; }
        public string PartyRequestId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual PartyRequest PartyRequest { get; set; }
    }
}
