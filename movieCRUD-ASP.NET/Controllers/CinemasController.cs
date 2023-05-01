using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieCRUD_ASP.NET.Data;

namespace movieCRUD_ASP.NET.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBcontext _context;

        public CinemasController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
