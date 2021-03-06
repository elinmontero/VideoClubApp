using System.Collections.Generic;
using System.Threading.Tasks;

using TheSpartanVideoClub.Models;

namespace TheSpartanVideoClub.Data.Service
{
    public interface IActorsService 
    {
        Task <IEnumerable<Actor>> GetAllAsync();
        Task <Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
        
    }

}
