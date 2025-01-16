using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        [ActionName("Index")]
        public string Index() => "Home";
        protected internal string Hello() => "Hello ASP.NET";
    }
}
