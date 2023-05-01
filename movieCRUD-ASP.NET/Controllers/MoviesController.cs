using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieCRUD_ASP.NET.Data;

namespace movieCRUD_ASP.NET.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBcontext _context;

        public MoviesController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(m=>m.Cinema).OrderBy(m=>m.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
