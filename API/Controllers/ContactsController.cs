using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly DataContext _context;
        public ContactsController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QBContactModel>>> Get()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return Ok(contacts);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QBContactModel>> Get(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            return Ok(contact);
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
