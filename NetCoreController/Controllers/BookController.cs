using Microsoft.AspNetCore.Mvc;

namespace NetCoreController.Controllers
{
    public class BookController : Controller
    {
        //-/Books?IsLogged=true&BookId=200
        [Route("Books")]
        public IActionResult Book()
        {
            return RedirectToAction("Books", "Store", null);

            /*if (!Request.Query.ContainsKey("IsLogged") && !Request.Query.ContainsKey("BookId"))
                return BadRequest();

            if (!Request.Query.ContainsKey("IsLogged"))
                return BadRequest();

            if (!Request.Query.ContainsKey("BookId"))
                return BadRequest("Book Id Is Not Provided.");

            int bookId = Convert.ToInt32(Request.Query["BookId"]);

            if (bookId < 1 || bookId > 100)
                return NotFound("Book Id Is Out Of Bound.");

            if (!Convert.ToBoolean(Request.Query["IsLogged"]))
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized);
            //return Unauthorized("User Is Not Logged In.");

            return File("/1.png", "image/png");*/
        }
    }
}
