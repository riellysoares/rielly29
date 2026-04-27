using Microsoft.AspNetCore.Mvc;

namespace rielly29.Controllers
{
    public class CidadeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }
    }
}