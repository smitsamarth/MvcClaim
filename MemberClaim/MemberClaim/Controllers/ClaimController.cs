using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberClaim.Model;
using MemberClaim.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberClaim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        // GET: api/<ClaimController>
        private readonly ICsvData csvData;

        public ClaimController(ICsvData csv)
        {
            csvData = csv;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            csvData.LoadClaimCsv();
            csvData.LoadMemberCsv();

            return (IEnumerable<string>)csvData.LoadMemberCsv();
        }

        // GET api/<ClaimController>/5
        [HttpGet("{date}")]
        public IEnumerable Get(DateTime date)
        {
            Member c1 = new Member();
            c1.FirstName = "smit";
            c1.LastName = "samarth";
            List<object> ol = new List<object>();
            ol.Add(c1);
            IEnumerable member = (IEnumerable<string>)csvData.LoadMemberCsv();
            IEnumerable claim = (IEnumerable<string>)csvData.LoadClaimCsv();
            //var res = from m in member
            //          join c in claim on m.MemberId equals c.MemberId
            //          where m.EnrollmentDate <= date
            //          select new
            //          {
            //              FirstName = m.FirstName,
            //              LastName = m.LastName,
            //              ClaimAmount = c.ClaimAmount
            //          };

            return member;
        }

        // POST api/<ClaimController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClaimController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClaimController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
