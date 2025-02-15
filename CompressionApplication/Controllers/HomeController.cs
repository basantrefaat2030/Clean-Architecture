using System.Diagnostics;
using Application.Interface;
using CompressionApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompressionApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompressionService _compressionService;

        public HomeController(ILogger<HomeController> logger , CompressionService compressionService)
        {
            _logger = logger;
            _compressionService = compressionService;
        }

        public IActionResult Index()
        {
            string path = "";
            // Compress the file and overwrite it
            _compressionService.CompressFile(path);
            return View();
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
