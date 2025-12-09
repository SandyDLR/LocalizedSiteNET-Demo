using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizedSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        public HomeController(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewBag.Hello = _localizer["Hello"];
            ViewBag.Welcome = _localizer["Welcome"];
            Console.WriteLine(_localizer["TEST_123"]);


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
