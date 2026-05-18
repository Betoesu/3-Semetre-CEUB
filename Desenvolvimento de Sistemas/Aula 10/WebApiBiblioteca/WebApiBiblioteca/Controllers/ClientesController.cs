using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
