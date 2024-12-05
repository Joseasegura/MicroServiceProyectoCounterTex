using Microsoft.EntityFrameworkCore;
using MicroServiceProyectoCounterTex.Repositories;
using MicroServiceProyectoCounterTex.Models;
using MicroServiceProyectoCounterTex.Repositories.Interfaces;

namespace MicroServiceProyectoCounterTex.Repositories
{
    public class UsuarioRepository : IUsuarios
    {
        private readonly CounterTexDBContext context;
        public UsuarioRepository(CounterTexDBContext context)
        {
            this.context = context;
        }
        public async Task<List<Usuarios>> GetUsuarios()
        {
            var data = await context.Usuarios.ToListAsync();
            return data;
        }
        public async Task<bool> PostUsuarios(Usuarios usuario)
        {
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutUsuarios(Usuarios usuario)
        {
            context.Usuarios.Update(usuario);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUsuarios(Usuarios usuario)
        {
            context.Usuarios.Remove(usuario);
            await context.SaveChangesAsync();
            return true;
        }

        public Task<bool> DeleteUsuarios(int id)
        {
            throw new NotImplementedException();
        }
    }
}
