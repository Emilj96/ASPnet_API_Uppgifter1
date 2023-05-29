using ASPnet_API_Uppgifter1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPnet_API_Uppgifter1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CDController : ControllerBase
    {

        public List<CD> cdlist = new List<CD>()
            {
            new CD() { Id = 1, Title = "Jake", Artist = "Jake" },
            new CD() { Id = 2, Title = "Jake", Artist = "Jake" },
            new CD() { Id = 3, Title = "Jake", Artist = "Jake" }
        };

        


        // GET: api/<CDController>
        [HttpGet]
        public ActionResult<CD> Get()
        {
            if (cdlist.Count > 0)
            {
                return Ok(cdlist[0]);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<CDController>/5
        [HttpGet("{id}")]
        public ActionResult<CD> Get(int id)
        {
            CD newcd = cdlist.FirstOrDefault(cd => cd.Id == id);

            Console.WriteLine(newcd);

            if (newcd == null)
            {
                return NotFound(id);
            }
            else
            {
                return Ok(newcd);
            }
        }

        // POST api/<CDController>
        [HttpPost]
        public ActionResult Post([FromBody] CD value)
        {
            if (cdlist.Any(cd => cd.Title == value.Title))
            {
                return BadRequest("cd already exists");
            }
            else
            {
                cdlist.Add(value);
            }
            return Ok();
        }

        // PUT api/<CDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
