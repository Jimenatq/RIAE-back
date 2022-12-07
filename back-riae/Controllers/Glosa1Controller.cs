using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    /*public class Glosa1Controller : Controller
    {
        private readonly AplicationDbContext _context;
        public Glosa1Controller(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listGlosa1 = await _context.glosa_FR1.ToListAsync();
                return Ok(listGlosa1);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] glosa_fr1 glosa_Fr1)
        {
            try
            {
                _context.glosa_FR1.Add(glosa_Fr1);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo registro de fondos rotatorios fue agregado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id_glosa)
        {
            try
            {
                if(id!= id_glosa)
                {
                    return NotFound();
                }

                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //DELETE
        [HttpDelete("{id_glosa}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var glosaFR1 = await _context.glosa_FR1.FindAsync(id);
                if(glosaFR1==null)
                {
                    return NotFound();
                }
                _context.Remove(glosaFR1);
                await _context.SaveChangesAsync();
                return Ok(new { message= "Glosa1 eliminada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
*/
}
