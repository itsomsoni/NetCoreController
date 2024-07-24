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
        public VirtualFileResult FileDownloadVirtual()
        {
            //return new VirtualFileResult("/1.png", "image/png");
            return File("/1.png", "image/png");
        }
        [Route("File/FileDownloadPhysical")]
        public PhysicalFileResult FileDownloadPhysical()
        {
            //return new PhysicalFileResult("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png", "image/png");
            return PhysicalFile("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png", "image/png");
        }
        [Route("File/FileDownloadFileContent")]
        public FileContentResult FileDownloadFileContent()
        {
            byte[] bytes = System.IO.File.ReadAllBytes("C:\\Users\\Developer3\\Pictures\\Screenshots\\Sample.png");
            return File(bytes, "image/png");
        }
    }
}
