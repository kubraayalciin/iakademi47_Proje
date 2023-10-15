using Microsoft.AspNetCore.Mvc;

namespace iakademi47_Proje.Controllers
{
    public class WebServiceController : Controller
    {
        public static string tckimlikno = "";
        public static string vergino = "";
        public IActionResult Index()
        {
            return View();
        }
    }
}
