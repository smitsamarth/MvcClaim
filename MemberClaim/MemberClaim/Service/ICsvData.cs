using MemberClaim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberClaim.Service
{
    public interface ICsvData
    {
        public  Member LoadMemberCsv();
        public Claim LoadClaimCsv();

    }
}
