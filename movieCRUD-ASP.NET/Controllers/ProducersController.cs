using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieCRUD_ASP.NET.Data;

namespace movieCRUD_ASP.NET.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBcontext _context;

        public ProducersController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
