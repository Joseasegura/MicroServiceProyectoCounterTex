using MicroServiceProyectoCounterTex.Models;

namespace MicroServiceProyectoCounterTex.Repositories.Interfaces
{
    public interface IAdministrador
    {
        
        Task<List<PerfilAdministrador>> GetAdministrador();
        Task<bool> PostAdministrador(PerfilAdministrador perfilAdministrador);
        Task<bool> PutAdministrador(PerfilAdministrador perfilAdministrador);
        Task<bool> DeleteAdministrador(PerfilAdministrador perfilAdministrador);
        Task<bool> DeleteAdministrador(int id);
    }
}
