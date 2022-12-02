namespace back_riae.Models.Repository
{
    public interface ItipoRepository
    {
        Task<tipos_registros> CreateTiposAsync(tipos_registros tipo_registro);
        Task<bool> DeleteTiposAsync(tipos_registros tipo_registro);
        tipos_registros GetTiposById(int id);
        IEnumerable<tipos_registros> GetTipos();
        Task<bool> UpdateTiposAsync(tipos_registros tipo_registro);
    }
}
