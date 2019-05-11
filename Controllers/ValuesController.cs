using System;
using System.Collections.Generic;
using System.Linq;
using DatingApp.API.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            
            List<DatingApp.API.Models.ValueProp> v = new List<DatingApp.API.Models.ValueProp>();
            DatingApp.API.Models.ValueProp val = new DatingApp.API.Models.ValueProp();
            
            val.Id= 1;
            val.Name="Test1";
            v.Add(val);
            val = new DatingApp.API.Models.ValueProp();
            val.Id= 2;
            val.Name="Test2";
            v.Add(val);
            val = new DatingApp.API.Models.ValueProp();
            val.Id=3;
            val.Name="Test3";
            v.Add(val);

            return Ok(v);
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
