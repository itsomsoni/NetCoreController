using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace NetCoreController.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return File("/1.png", "image/png");
            //return View();
        }

        [Route("File/FileDownloadVirtual")]
        public IActionResult FileDownloadVirtual()
        {
            //return new VirtualFileResult("/1.png", "image/png");
            return File("/1.png", "image/png");
        }
        [Route("File/FileDownloadPhysical")]
        public IActionResult FileDownloadPhysical()
        {
            if (!System.IO.File.Exists("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample1.png"))
            {
                return new NotFoundResult();
                //return Content("File Doesn't Exists.", "text/plain");
            }

            //return new PhysicalFileResult("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png", "image/png");
            return PhysicalFile("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png", "image/png");
        }
        [Route("File/FileDownloadFileContent")]
        public IActionResult FileDownloadFileContent()
        {
            byte[] bytes = System.IO.File.ReadAllBytes("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png");
            return File(bytes, "image/png");
        }
    }
}
