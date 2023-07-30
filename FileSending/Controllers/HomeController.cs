using Microsoft.AspNetCore.Mvc;

namespace FileSending.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _appEnvironment;
        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            string filePath = Path.Combine(_appEnvironment.ContentRootPath,
                @"Files\HelloFile.txt");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            string fileType = "text/plain";
            string fileName = "File.txt";
            return File(fs, fileType, fileName);
        }
    }
}
