using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registroFRController : Controller
    {
        private readonly AplicationDbContext _context;
        public registroFRController(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listRegistroFR = await _context.registro_Frotatorios.ToListAsync();
                return Ok(listRegistroFR);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] registro_frotatorios registro_Frotatorios)
        {
            try
            {
                _context.registro_Frotatorios.Add(registro_Frotatorios);
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
        public async Task<IActionResult> Put(int id, [FromBody] registro_frotatorios registro_Frotatorios)
        {
            try
            {
                if (id != registro_Frotatorios.id_registro)
                {
                    return NotFound();
                }
                _context.Entry(registro_Frotatorios).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo registro de fondos rotatorios fue modificado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var registro_Frotatorios = await _context.registro_Frotatorios.FindAsync(id);
                if (registro_Frotatorios == null)
                {
                    return NotFound();
                }
                _context.Remove(registro_Frotatorios);
                await _context.SaveChangesAsync();
                return Ok(new { message = "registro FR eliminada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
