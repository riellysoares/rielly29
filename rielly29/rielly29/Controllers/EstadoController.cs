using Microsoft.AspNetCore.Mvc;

namespace rielly29.Controllers 
{
    public class EstadoController : Controller
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