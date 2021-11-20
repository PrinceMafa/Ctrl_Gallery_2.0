using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ctrl_Gallery_2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Web;
using System.Data;

namespace Ctrl_Gallery_2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment hostE;
        public HomeController(IWebHostEnvironment environment_)
        {
            hostE=environment_;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult showFields(IFormFile image, string fileName, string capturedBy, string tag, string location, DateTime date)
        {
            ViewData["fileN"] = fileName;
            ViewData["captured"] = capturedBy;
            ViewData["tag"] = tag;
            ViewData["Geolocation"] = location;
            ViewData["date"] = date;
            if(image != null)
            {
                var FileName = Path.Combine(hostE.WebRootPath,Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(FileName,FileMode.Create));
                ViewData["fileLocation"] = fileName;
            }
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
