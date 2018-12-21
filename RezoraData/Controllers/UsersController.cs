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
    public class UsersController : Controller
    {
        private RezoraDataContext _context;

        public UsersController(RezoraDataContext context)
        {
            _context = context;
        }

        // GET: api/users
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_context.Users);
        }

        // GET: api/users/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            Users user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User object is null");
            }

            return Ok(user);
        }

        // POST: api/users
        [HttpPost]
        public IActionResult AddUser([FromBody]Users user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Add(user);
                return CreatedAtRoute("AddUser", new { id = user.UserId }, user);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the AddUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // PUT: api/users/5
        [HttpPut("{id}")]
        public IActionResult PutUser(Guid id, [FromBody]Users user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("User object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                _context.Update(user);
                return CreatedAtRoute("UpdateUser", new { id = user.UserId }, user);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the UpdateUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // DELETE: api/users/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
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
                Users user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return CreatedAtRoute("DeleteUser", new { id = user.UserId }, user);
            }
            catch (Exception ex)
            {
                Console.Write($"Something went wrong inside the DeleteUser action: {ex}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
