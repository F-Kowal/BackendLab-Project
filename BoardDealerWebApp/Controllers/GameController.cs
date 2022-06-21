using BoardDealerWebApp.Data;
using BoardDealerWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardDealerWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GameController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Game> objGameList = _db.Games;
            return View(objGameList);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Game obj)
        {
            _db.Games.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
