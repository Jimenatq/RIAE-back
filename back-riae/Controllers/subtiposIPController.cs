using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class subtiposIPController : Controller
    {
        private readonly AplicationDbContext _context;
        public subtiposIPController(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listSubtipos = await _context.subtipo_Ingresos_IP.ToListAsync();
                return Ok(listSubtipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] subtipo_ingresos_ip subtipo_Ingresos_IP)
        {
            try
            {
                _context.subtipo_Ingresos_IP.Add(subtipo_Ingresos_IP);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El nuevo subtipo IP fue agregado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
