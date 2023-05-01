using Microsoft.AspNetCore.Mvc;
using movieCRUD_ASP.NET.Data;

namespace movieCRUD_ASP.NET.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBcontext _context;

        public ActorsController(AppDBcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
