using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberClaim.Model
{
    public class Claim
    {
        public int? MemberId { get; set; }
        public DateTime ClaimeDate { get; set; }
        public double ClaimAmount { get; set; }

       
    }
}
