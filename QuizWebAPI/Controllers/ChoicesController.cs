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
    public class ChoicesController : ControllerBase
    {
        private readonly QuizContext _context;

        public ChoicesController(QuizContext context)
        {
            _context = context;
        }

        // GET: api/Choices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Choices>>> GetQuestionChoices()
        {
            return await _context.Choices.ToListAsync();
        }

        // GET: api/Choices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Choices>> GetQuestionChoices(int id)
        {
            var questionChoices = await _context.Choices.FindAsync(id);

            if (questionChoices == null)
            {
                return NotFound();
            }

            return questionChoices;
        }

        // PUT: api/Choices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestionChoices(int id, Choices questionChoices)
        {
            if (id != questionChoices.id)
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

        // POST: api/Choices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Choices>> PostQuestionChoices(Choices questionChoices)
        {
            _context.Choices.Add(questionChoices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestionChoices", new { id = questionChoices.id }, questionChoices);
        }

        // DELETE: api/Choices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Choices>> DeleteQuestionChoices(int id)
        {
            var questionChoices = await _context.Choices.FindAsync(id);
            if (questionChoices == null)
            {
                return NotFound();
            }

            _context.Choices.Remove(questionChoices);
            await _context.SaveChangesAsync();

            return questionChoices;
        }

        private bool QuestionChoicesExists(int id)
        {
            return _context.Choices.Any(e => e.id == id);
        }
    }
}
