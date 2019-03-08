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
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoesController : ControllerBase
    {
        private readonly SmartU2Context _context;

        public VehiculoesController(SmartU2Context context)
        {
            _context = context;
        }

        // GET: api/Vehiculoes
        [HttpGet]
        public IEnumerable<Vehiculo> GetVehiculo()
        {
            return _context.Vehiculo;
        }

        // GET: api/Vehiculoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehiculo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehiculo = await _context.Vehiculo.FindAsync(id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return Ok(vehiculo);
        }

        // PUT: api/Vehiculoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo([FromRoute] int id, [FromBody] Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehiculo.idVehiculo)
            {
                return BadRequest();
            }

            _context.Entry(vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(id))
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

        // POST: api/Vehiculoes
        [HttpPost]
        public async Task<IActionResult> PostVehiculo([FromBody] Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vehiculo.Add(vehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculo", new { id = vehiculo.idVehiculo }, vehiculo);
        }

        // DELETE: api/Vehiculoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehiculo = await _context.Vehiculo.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculo.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return Ok(vehiculo);
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculo.Any(e => e.idVehiculo == id);
        }
    }
}