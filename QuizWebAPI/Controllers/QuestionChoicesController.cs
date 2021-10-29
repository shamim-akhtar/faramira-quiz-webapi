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
    public class QuestionChoicesController : ControllerBase
    {
        private readonly QuizContext _context;

        public QuestionChoicesController(QuizContext context)
        {
            _context = context;
        }

        // GET: api/QuestionChoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionChoices>>> GetQuestionChoices()
        {
            return await _context.QuestionChoices.ToListAsync();
        }

        // GET: api/QuestionChoices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionChoices>> GetQuestionChoices(int id)
        {
            var questionChoices = await _context.QuestionChoices.FindAsync(id);

            if (questionChoices == null)
            {
                return NotFound();
            }

            return questionChoices;
        }

        // PUT: api/QuestionChoices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestionChoices(int id, QuestionChoices questionChoices)
        {
            if (id != questionChoices.choice_id)
            {
                return BadRequest();
            }

            _context.Entry(questionChoices).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionChoicesExists(id))
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

        // POST: api/QuestionChoices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<QuestionChoices>> PostQuestionChoices(QuestionChoices questionChoices)
        {
            _context.QuestionChoices.Add(questionChoices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestionChoices", new { id = questionChoices.choice_id }, questionChoices);
        }

        // DELETE: api/QuestionChoices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QuestionChoices>> DeleteQuestionChoices(int id)
        {
            var questionChoices = await _context.QuestionChoices.FindAsync(id);
            if (questionChoices == null)
            {
                return NotFound();
            }

            _context.QuestionChoices.Remove(questionChoices);
            await _context.SaveChangesAsync();

            return questionChoices;
        }

        private bool QuestionChoicesExists(int id)
        {
            return _context.QuestionChoices.Any(e => e.choice_id == id);
        }
    }
}
