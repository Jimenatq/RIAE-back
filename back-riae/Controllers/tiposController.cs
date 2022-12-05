using back_riae.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class tiposController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public tiposController(AplicationDbContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listTipos = await _context.tipos_Registros.ToListAsync();
                return Ok(listTipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


