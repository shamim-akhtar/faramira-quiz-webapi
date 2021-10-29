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
    public class AttemptsController : ControllerBase
    {
        private readonly QuizContext _context;

        public AttemptsController(QuizContext context)
        {
            _context = context;
        }

        // GET: api/Attempts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attempts>>> GetUserQuestionAnswers()
        {
            return await _context.Attempts.ToListAsync();
        }

        // GET: api/Attempts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attempts>> GetUserQuestionAnswers(int id)
        {
            var userQuestionAnswers = await _context.Attempts.FindAsync(id);

            if (userQuestionAnswers == null)
            {
                return NotFound();
            }

            return userQuestionAnswers;
        }

        // PUT: api/Attempts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserQuestionAnswers(int id, Attempts userQuestionAnswers)
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

        // POST: api/Attempts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Attempts>> PostUserQuestionAnswers(Attempts userQuestionAnswers)
        {
            _context.Attempts.Add(userQuestionAnswers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserQuestionAnswers", new { id = userQuestionAnswers.id }, userQuestionAnswers);
        }

        // DELETE: api/Attempts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Attempts>> DeleteUserQuestionAnswers(int id)
        {
            var userQuestionAnswers = await _context.Attempts.FindAsync(id);
            if (userQuestionAnswers == null)
            {
                return NotFound();
            }

            _context.Attempts.Remove(userQuestionAnswers);
            await _context.SaveChangesAsync();

            return userQuestionAnswers;
        }

        private bool UserQuestionAnswersExists(int id)
        {
            return _context.Attempts.Any(e => e.id == id);
        }
    }
}
