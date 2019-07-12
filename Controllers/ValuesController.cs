using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appglobal;
using Microsoft.AspNetCore.Mvc;

namespace materi_docker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            webapi_db _context = new webapi_db(AppGlobal.get_db_option());
            var data = _context.m_bulan.ToList();
            return new string[] { data[0].m_bulan_nama, data[1].m_bulan_nama };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
