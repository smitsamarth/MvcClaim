using CsvHelper.Configuration;
using MemberClaim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberClaim.Service
{
    public sealed class MemberMapper : ClassMap<Member>
    {
        public MemberMapper()
        {
            Map(x => x.MemberId).Name("MemberID");
            Map(x => x.EnrollmentDate).Name("EnrollmentDate");
            Map(x => x.FirstName).Name("FirstName");
            Map(x => x.LastName).Name("LastName");

        }
    }
}
