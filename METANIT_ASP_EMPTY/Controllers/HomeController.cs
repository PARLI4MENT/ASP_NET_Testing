using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace METANIT_ASP_EMPTY.Controllers
{
    public class HomeController : Controller
    {
        IActionResult Index()
        {
            return View();
        }
    }
}