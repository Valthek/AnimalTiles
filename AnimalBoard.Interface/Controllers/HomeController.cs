using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AnimalBoard.Interface.Models;
using AnimalBoard.Objects;
using AnimalBoard.Services;

namespace AnimalBoard.Interface.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GameService game = new GameService(20, 20);
            AnimalBoardModel model = new AnimalBoardModel()
            {
                Tiles = game.Board
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
