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
        // GET: api/Zonas
        // GET: api/Zonas/(NumeroZona)
        // POST: api/Zonas
        // PUT: api/Zonas/(NumeroZona)
        // DELETE: api/Zonas/(NumeroZona)
        para en envio de datos al frontend
    */
    [Route("api/[controller]")]
    [ApiController]
    public class ZonasController : ControllerBase
    {
        private readonly SmartU2Context _context;

        public ZonasController(SmartU2Context context)
        {
            _context = context;
        }

        // GET: api/Zonas
        [HttpGet]
        public IEnumerable<Zona> GetZona()
        {
            return _context.Zona;
        }

        // GET: api/Zonas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetZona([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var zona = await _context.Zona.FindAsync(id);

            if (zona == null)
            {
                return NotFound();
            }

            return Ok(zona);
        }

        // PUT: api/Zonas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZona([FromRoute] int id, [FromBody] Zona zona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zona.IdZona)
            {
                return BadRequest();
            }

            _context.Entry(zona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZonaExists(id))
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

        // POST: api/Zonas
        [HttpPost]
        public async Task<IActionResult> PostZona([FromBody] Zona zona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Zona.Add(zona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZona", new { id = zona.IdZona }, zona);
        }

        // DELETE: api/Zonas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZona([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var zona = await _context.Zona.FindAsync(id);
            if (zona == null)
            {
                return NotFound();
            }

            _context.Zona.Remove(zona);
            await _context.SaveChangesAsync();

            return Ok(zona);
        }

        private bool ZonaExists(int id)
        {
            return _context.Zona.Any(e => e.IdZona == id);
        }
    }
}