using Microsoft.AspNetCore.Mvc;
using PlotBoxTechEx.Models;
using System.Diagnostics;

namespace PlotBoxTechEx.Controllers
{
    public class PostcodeController : Controller
    {
        private readonly ILogger<PostcodeController> _logger;

        public PostcodeController(ILogger<PostcodeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostcodeData()
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