using CsvHelper;
using MemberClaim.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClaim.Service
{
    public class CsvData:ICsvData
    {
        public Member LoadMemberCsv()
        {
            string location1 = @"C:\Member.csv";
            try
            {
                using (var reader = new StreamReader(location1, Encoding.Default))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<MemberMapper>();
                    var records = csv.GetRecord<Member>();
                    return records;
                }
            }

            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public Claim LoadClaimCsv()
        {
            string location1 = @"C:\Claim.csv";
            try
            {
                using (var reader = new StreamReader(location1, Encoding.Default))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<ClaimMapper>();
                    var records = csv.GetRecord<Claim>();
                    return records;
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
