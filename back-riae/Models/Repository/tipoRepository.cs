using Microsoft.EntityFrameworkCore;

namespace back_riae.Models.Repository
{
    public class tipoRepository : ItipoRepository
    {
        
        protected readonly AplicationDbContext _context;
        public tipoRepository(AplicationDbContext context) => _context = context;

        public IEnumerable<tipos_registros> GetTipos()
        {
            return _context.tipos_Registros.ToList();
        }

        public tipos_registros GetTiposById(int id)
        {
            return _context.tipos_Registros.Find(id);
        }
        public async Task<tipos_registros> CreateTiposAsync(tipos_registros tipo_registro)
        {
            await _context.Set<tipos_registros>().AddAsync(tipo_registro);
            await _context.SaveChangesAsync();
            return tipo_registro;
        }

        public async Task<bool> UpdateTiposAsync(tipos_registros tipo_registro)
        {
            _context.Entry(tipo_registro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTiposAsync(tipos_registros tipo_registro)
        {
            //var entity = await GetByIdAsync(id);
            if (tipo_registro is null)
            {
                return false;
            }
            _context.Set<tipos_registros>().Remove(tipo_registro);
            await _context.SaveChangesAsync();

            return true;
        }
    
    }
}
