using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartU2.Models;

namespace SmartU2.Controllers
{
    /*
        Clase controladora de los Slots
        En esta clase se realiza un servicio rest Full
        posee metodos get, post, put y delete
        para los metodos get y post solo se necesita la sguiente URL
        // GET: api/SlotParqueaderoes
        // GET: api/SlotParqueaderoes/(SlotParqueaderos)
        // POST: api/SlotParqueaderoes
        // PUT: api/SlotParqueaderoes/(SlotParqueaderos)
        // DELETE: api/SlotParqueaderoes/(SlotParqueaderoes)
        para en envio de datos al frontend
    */
    [Route("api/[controller]")]
    [ApiController]
    public class SlotParqueaderoesController : ControllerBase
    {
        private readonly SmartU2Context _context;

        public SlotParqueaderoesController(SmartU2Context context)
        {
            _context = context;
        }

        // GET: api/SlotParqueaderoes
        
        [HttpGet]
        public IEnumerable<SlotParqueadero> GetSlotParqueadero()
        {
            return _context.SlotParqueadero;
        }

        // GET: api/SlotParqueaderoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlotParqueadero([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var slotParqueadero = await _context.SlotParqueadero.FindAsync(id);

            if (slotParqueadero == null)
            {
                return NotFound();
            }

            return Ok(slotParqueadero);
        }

        // PUT: api/SlotParqueaderoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlotParqueadero([FromRoute] int id, [FromBody] SlotParqueadero slotParqueadero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != slotParqueadero.IdSlotParqueadero)
            {
                return BadRequest();
            }

            _context.Entry(slotParqueadero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotParqueaderoExists(id))
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

        // POST: api/SlotParqueaderoes
        [HttpPost]
        public async Task<IActionResult> PostSlotParqueadero([FromBody] SlotParqueadero slotParqueadero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SlotParqueadero.Add(slotParqueadero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSlotParqueadero", new { id = slotParqueadero.IdSlotParqueadero }, slotParqueadero);
        }

        // DELETE: api/SlotParqueaderoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlotParqueadero([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var slotParqueadero = await _context.SlotParqueadero.FindAsync(id);
            if (slotParqueadero == null)
            {
                return NotFound();
            }

            _context.SlotParqueadero.Remove(slotParqueadero);
            await _context.SaveChangesAsync();

            return Ok(slotParqueadero);
        }

        private bool SlotParqueaderoExists(int id)
        {
            return _context.SlotParqueadero.Any(e => e.IdSlotParqueadero == id);
        }
    }
}