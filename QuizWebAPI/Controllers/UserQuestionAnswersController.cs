using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizWebAPI.Models;

namespace QuizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserQuestionAnswersController : ControllerBase
    {
        private readonly QuizContext _context;

        public UserQuestionAnswersController(QuizContext context)
        {
            _context = context;
        }

        // GET: api/UserQuestionAnswers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserQuestionAnswers>>> GetUserQuestionAnswers()
        {
            return await _context.UserQuestionAnswers.ToListAsync();
        }

        // GET: api/UserQuestionAnswers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserQuestionAnswers>> GetUserQuestionAnswers(int id)
        {
            var userQuestionAnswers = await _context.UserQuestionAnswers.FindAsync(id);

            if (userQuestionAnswers == null)
            {
                return NotFound();
            }

            return userQuestionAnswers;
        }

        // PUT: api/UserQuestionAnswers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserQuestionAnswers(int id, UserQuestionAnswers userQuestionAnswers)
        {
            if (id != userQuestionAnswers.id)
            {
                return BadRequest();
            }

            _context.Entry(userQuestionAnswers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserQuestionAnswersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserQuestionAnswers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserQuestionAnswers>> PostUserQuestionAnswers(UserQuestionAnswers userQuestionAnswers)
        {
            _context.UserQuestionAnswers.Add(userQuestionAnswers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserQuestionAnswers", new { id = userQuestionAnswers.id }, userQuestionAnswers);
        }

        // DELETE: api/UserQuestionAnswers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserQuestionAnswers>> DeleteUserQuestionAnswers(int id)
        {
            var userQuestionAnswers = await _context.UserQuestionAnswers.FindAsync(id);
            if (userQuestionAnswers == null)
            {
                return NotFound();
            }

            _context.UserQuestionAnswers.Remove(userQuestionAnswers);
            await _context.SaveChangesAsync();

            return userQuestionAnswers;
        }

        private bool UserQuestionAnswersExists(int id)
        {
            return _context.UserQuestionAnswers.Any(e => e.id == id);
        }
    }
}
