using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using TheSpartanVideoClub.Data.Enums;
using TheSpartanVideoClub.Models;

namespace TheSpartanVideoClub.Data.Service
{
    public class ActorsService : IActorsService
    {
        private readonly ContextoAppBd _contexto;
        public ActorsService(ContextoAppBd contexto)
        {
            _contexto = contexto;
        }
        public async Task AddAsync(Actor actor)
        {
           await _contexto.Actors.AddAsync(actor);
            await _contexto.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task <IEnumerable<Actor>> GetAllAsync()
        {
            var resultado = await _contexto.Actors.ToListAsync();
                return resultado;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
           var resultado = await _contexto.Actors.FirstOrDefaultAsync(n => n.IdActor == id);
            return resultado;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _contexto.Update(newActor);
            await _contexto.SaveChangesAsync();
            return newActor;
        }
    }
}
