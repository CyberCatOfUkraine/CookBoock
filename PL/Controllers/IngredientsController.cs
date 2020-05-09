using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class IngredientsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}