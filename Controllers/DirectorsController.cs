using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TheSpartanVideoClub.Data.Enums;

namespace TheSpartanVideoClub.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly ContextoAppBd _contexto;

        public DirectorsController(ContextoAppBd contexto)
        {
            _contexto = contexto;
        }

        // GET: Directors
        public async Task<ActionResult> Index()
        {
            var direc = await _contexto.Directors.ToListAsync();
            return View(direc);
        }

    }
}
