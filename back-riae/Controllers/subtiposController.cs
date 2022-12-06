using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class subtiposController : Controller
    {
        private readonly AplicationDbContext _context;
        public subtiposController(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listSubtipos = await _context.subtipo_Ingresos.ToListAsync();
                return Ok(listSubtipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] subtipo_ingresos subtipo_Ingresos)
        {
            try
            {
                _context.subtipo_Ingresos.Add(subtipo_Ingresos);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo subtipo fue agregado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
