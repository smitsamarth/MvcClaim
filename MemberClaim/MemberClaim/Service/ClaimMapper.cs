using CsvHelper.Configuration;
using MemberClaim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberClaim.Service
{
    public sealed class ClaimMapper : ClassMap<Claim>
    {
        public ClaimMapper()
        {
            Map(x => x.MemberId).Name("MemberID");
            Map(x => x.ClaimeDate).Name("ClaimeDate");
            Map(x => x.ClaimAmount).Name("ClaimAmount");
        }
    }
}
