using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using RezoraData.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace RezoraData.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : Controller
    {

        private RezoraDataContext _context;

        public ContactsController(RezoraDataContext context)
        {
            _context = context;
        }

        // GET: api/contacts
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return Ok(_context.Contacts);
        }

        // GET: api/contacts/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "GetContact")]
        public async Task<IActionResult> GetContact(int id)
        {
            Contacts contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: api/contacts
        [HttpPost]
        public IActionResult AddContact([FromBody]Contacts contact)
        {
            try
            {
                if (contact == null)
                {
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Add(contact);
                return CreatedAtRoute("ContactById", new { id = contact.ContactId }, contact);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the CreateOwner action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // PUT: api/contacts/5
        [HttpPut("{id}")]
        public IActionResult PutContact(Guid id, [FromBody]Contacts contact)
        {
            try
            {
                if(contact == null)
                {
                    return BadRequest("Contact object is null");
                }
                if(!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Update(contact);
                return CreatedAtRoute("UpdateContact", new { id = contact.ContactId }, contact);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the UpdateContact action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // DELETE: api/contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(Guid id)
        {
            try
            {
                if (id.Equals(0))
                {
                    return BadRequest("ContactId cannot be zero");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                Contacts contact = await _context.Contacts.FindAsync(id);
                if (contact == null)
                {
                    return NotFound();
                }
                _context.Remove(contact);
                await _context.SaveChangesAsync();
                return CreatedAtRoute("DeleteContact", new { id = contact.ContactId }, contact);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the UpdateContact action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

    }
}
