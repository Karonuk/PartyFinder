using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities
{
    public class GameToTag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public long TagId { get; set; }
        public long GameId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
