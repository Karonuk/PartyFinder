using Microsoft.AspNetCore.Identity;
using PartyFinder.DAL.Entities.Profiles.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyFinder.DAL.Entities.Identity
{
    public class DbUser : IdentityUser
    {
        public virtual BaseProfile BaseProfile { get; set; }
    }
}
