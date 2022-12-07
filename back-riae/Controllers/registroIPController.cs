using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registroIPController : Controller
    {
        private readonly AplicationDbContext _context;
        public registroIPController(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listRegistroIP = await _context.registro_Ipropios.ToListAsync();
                return Ok(listRegistroIP);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] registro_ipropios registro_Ipropios)
        {
            try
            {
                _context.registro_Ipropios.Add(registro_Ipropios);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo registro de ingresos propios fue agregado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] registro_ipropios registro_Ipropios)
        {
            try
            {
                if (id != registro_Ipropios.id_registro)
                {
                    return NotFound();
                }
                _context.Entry(registro_Ipropios).State= EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo registro de ingresos propios fue modificado con exito" });
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
                var registro_Ipropios = await _context.registro_Ipropios.FindAsync(id);
                if (registro_Ipropios == null)
                {
                    return NotFound();
                }
                _context.Remove(registro_Ipropios);
                await _context.SaveChangesAsync();
                return Ok(new { message = "registro IP eliminada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
