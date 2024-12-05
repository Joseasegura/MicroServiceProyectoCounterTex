using Microsoft.EntityFrameworkCore;

using MicroServiceProyectoCounterTex.Repositories.Interfaces;
using MicroServiceProyectoCounterTex.Models;
using MicroServiceProyectoCounterTex.Repositories;


namespace MicroServiceProyectoCounterTex.Repositories.Interfaces
{


    public class TokensRepository : ITokens
        {
            private readonly CounterTexDBContext context;

            public TokensRepository(CounterTexDBContext context)
            {
                this.context = context;
            }

            public async Task<List<Tokens>> GetTokens()
            {
                var data = await context.Tokens.ToListAsync();
                return data;
            }

            public async Task<bool> PostTokens(Tokens tokens)
            {
                await context.Tokens.AddAsync(tokens);
                await context.SaveAsync();
                return true;
            }
            public async Task<bool> PutTokens(Tokens tokens)
            {
                context.Tokens.Update(tokens);
                await context.SaveAsync();
                return true;
            }
            public async Task<bool> DeleteTokens(Tokens tokens)
            {
                context.Tokens.Remove(tokens);
                await context.SaveAsync();
                return true;
            }
        }


    
}
