using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using RezoraData.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RezoraData.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersToContactsController : Controller
    {
        private RezoraDataContext _context;

        public UsersToContactsController(RezoraDataContext context)
        {
            _context = context;
        }

        // GET: api/userstocontacts/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "GetUserToContacts")]
        public async Task<IActionResult> GetUserToContacts(int userId)
        {
            UsersToContacts userContacts = await _context.UsersToContacts.FindAsync(userId);
            if (userContacts == null)
            {
                return BadRequest("User object is null");
            }

            return Ok(userContacts);
        }

        /// <summary>
        ///     Associates a contact with a user
        /// </summary>
        /// <returns>The contact created for the user.</returns>
        /// <param name="contact">UsersToContact</param>
        /// <response code="201">Returns the newly created contact to user association</response>
        /// <response code="400">If the item is null</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        public IActionResult AddContactToUser([FromBody]UsersToContacts contact)
        {
            try
            {
                if (contact == null)
                {
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Add(contact);
                return CreatedAtRoute("AddContactToUser", new { contactId = contact.ContactId, userId = contact.UserId }, contact);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the AddUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // PUT: api/userstocontacts/5
        [HttpPut("{id}")]
        public IActionResult PutUserToContacts(Guid id, [FromBody]UsersToContacts userToContacts)
        {
            try
            {
                if(userToContacts == null)
                {
                    return BadRequest("UserToContact is not set");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Update(userToContacts);
                return CreatedAtRoute("UpdateUser", new { id = userToContacts.UsertocontactId }, userToContacts);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the UpdateUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // DELETE: api/userstocontacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserToContact(Guid id)
        {
            try
            {
                if (id.Equals(0))
                {
                    return BadRequest("UserId cannot be zero");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                UsersToContacts userToContacts = await _context.UsersToContacts.FindAsync(id);
                if (userToContacts == null)
                {
                    return NotFound();
                }
                _context.Remove(userToContacts);
                await _context.SaveChangesAsync();
                return CreatedAtRoute("DeleteUserToContact", new { id = userToContacts.UsertocontactId }, userToContacts);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the DeleteUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
