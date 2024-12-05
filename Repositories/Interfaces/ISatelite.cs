﻿using MicroServiceProyectoCounterTex.Models;

namespace MicroServiceProyectoCounterTex.Repositories.Interfaces
{
    public interface ISatelite
    {

        Task<List<Satelite>> GetSatelites();
        Task<bool> PostSatelite(Satelite satelite);
        Task<bool> PutSatelite(Satelite satelite);
        Task<bool> DeleteSatelite(Satelite satelite);
        Task<bool> DeleteSatelite(int id);
    }

}
