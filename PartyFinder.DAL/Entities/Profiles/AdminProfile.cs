using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyFinder.DAL.Entities.Profiles
{
    public class AdminProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public virtual BaseProfile BaseProfile { get; set; }
    }
}
