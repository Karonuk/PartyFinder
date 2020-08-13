using PartyFinder.DAL.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyFinder.UI.Interface
{
    public interface IJwtTokenService
    {
        string CreateToken(DbUser user);
    }
}
