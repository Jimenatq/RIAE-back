using back_riae.Models;
using back_riae.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class tiposController : ControllerBase
    {
        private ItipoRepository _tipoRepository;

        public tiposController(ItipoRepository tipoRepository)
        {
            _tipoRepository = tipoRepository;
        }

        [HttpGet]
        [ActionName(nameof(GetTiposAsync))]
        public IEnumerable<tipos_registros> GetTiposAsync()
        {
            return _tipoRepository.GetTipos();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetTiposById))]
        public ActionResult<tipos_registros> GetTiposById(int id)
        {
            var tiposByID = _tipoRepository.GetTiposById(id);
            if (tiposByID == null)
            {
                return NotFound();
            }
            return tiposByID;
        }
        [HttpPost]
        [ActionName(nameof(CreateTiposAsync))]
        public async Task<ActionResult<tipos_registros>> CreateTiposAsync(tipos_registros tipo_registro)
        {
            await _tipoRepository.CreateTiposAsync(tipo_registro);
            return CreatedAtAction(nameof(GetTiposById), new { id = tipo_registro.id }, tipo_registro);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdateTipos))]
        public async Task<ActionResult> UpdateTipos(int id, tipos_registros tipo_registro)
        {
            if (id != tipo_registro.id)
            {
                return BadRequest();
            }

            await _tipoRepository.UpdateTiposAsync(tipo_registro);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteTipos))]
        public async Task<IActionResult> DeleteTipos(int id)
        {
            var tipo_registro = _tipoRepository.GetTiposById(id);
            if (tipo_registro == null)
            {
                return NotFound();
            }

            await _tipoRepository.DeleteTiposAsync(tipo_registro);

            return NoContent();
        }
    }
}


