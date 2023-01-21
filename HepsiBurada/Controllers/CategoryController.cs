using Microsoft.AspNetCore.Mvc;

namespace HepsiBurada.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
