using System.Diagnostics;
using System.Text;
using DIService_Lifetime.Models;
using DIService_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIService_Lifetime.Controllers
{
    public class HomeController : Controller
       
    {
        private readonly ITransientGuidService _transient1;
        private readonly ITransientGuidService _transient2;

        private readonly IScopedGuidService _scoped1;
        private readonly IScopedGuidService _scoped2;

        private readonly ISingletonGuidService _singleton1;
        private readonly ISingletonGuidService _singleton2;


        private readonly ILogger<HomeController> _logger;

        public HomeController( IScopedGuidService scopedGuid1,IScopedGuidService scopedGuid2
            ,ISingletonGuidService singletonGuid1,ISingletonGuidService singletonGuid2,
            ITransientGuidService transientGuid1, ITransientGuidService transientGuid2)
        {
            _scoped1 = scopedGuid1;
            _scoped2 = scopedGuid2;
            _singleton1 = singletonGuid1;
            _singleton2 = singletonGuid2;
            _transient1 = transientGuid1;
            _transient2 = transientGuid2;
        }

        public IActionResult Index()
        {
            StringBuilder messages = new StringBuilder();


            // Assuming messages is a StringBuilder or similar
            messages.Append($"Transient 1: {_transient1.GetGuid()}\n");
            messages.Append($"Transient 2: {_transient2.GetGuid()}\n");
            messages.Append($"Scoped 1: {_scoped1.GetGuid()}\n");
            messages.Append($"Scoped 2: {_scoped2.GetGuid()}\n");
            messages.Append($"Singleton 1: {_singleton1.GetGuid()}\n");
            messages.Append($"Singleton 2: {_singleton2.GetGuid()}\n");
            return Ok(messages.ToString()
                );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
