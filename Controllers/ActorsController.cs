using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TheSpartanVideoClub.Data.Enums;
using TheSpartanVideoClub.Data.Service;
using TheSpartanVideoClub.Models;

namespace TheSpartanVideoClub.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        // GET: Actors
        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAllAsync();
            return View(data);
        }
        
        //Get Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("NombreActor, FotoPerfilActor")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }
        // Obtener Actor by Id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails= await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            else
            {
                return View(actorDetails);
            }
        }
        //Metodo para actualizar detalles del actor
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            else
            {
                return View(actorDetails);
            }

           
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id,[Bind("IdActor, NombreActor, FotoPerfilActor")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
             await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }
        // Metodo para borrar actor
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetAllAsync();
            if (actorDetails == null)
                return View("NotFound");
            else
            {
                return View(actorDetails);
            }


        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetAllAsync();
            if (actorDetails == null)

            _service.Delete(id);            
            return RedirectToAction(nameof(Index));

        }
    }
}
