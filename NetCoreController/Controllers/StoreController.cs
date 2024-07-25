using Microsoft.AspNetCore.Mvc;

namespace NetCoreController.Controllers
{
    public class StoreController : Controller
    {
        [Route("Category/Books")]
        public IActionResult Books()
        {
            return View();
        }
    }
}
