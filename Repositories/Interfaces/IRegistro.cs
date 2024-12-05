using MicroServiceProyectoCounterTex.Models;

namespace MicroServiceProyectoCounterTex.Repositories.Interfaces
{
    public interface IRegistro
    {
        Task<List<Registro>> GetRegistro();
        Task<bool> PostRegistro(Registro registro);
        Task<bool> PutRegistro(Registro registro);
        Task<bool> DeleteRegistro(int id);
    }
}
