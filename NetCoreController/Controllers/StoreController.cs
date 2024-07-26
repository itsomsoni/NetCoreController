using Microsoft.AspNetCore.Mvc;

namespace NetCoreController.Controllers
{
    public class StoreController : Controller
    {
        [Route("Category/Books/{BookId:int}/{IsLogged:bool}")]
        public IActionResult Books()
        {
            if (!Request.RouteValues.ContainsKey("IsLogged") && !Request.RouteValues.ContainsKey("BookId"))
                return BadRequest();

            if (!Request.RouteValues.ContainsKey("IsLogged"))
                return BadRequest();

            if (!Request.RouteValues.ContainsKey("BookId"))
                return BadRequest("Book Id Is Not Provided.");

            int bookId = Convert.ToInt32(Request.RouteValues["BookId"]);

            if (bookId < 1 || bookId > 100)
                return NotFound("Book Id Is Out Of Bound.");

            if (!Convert.ToBoolean(Request.RouteValues["IsLogged"]))
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized);
            //return Unauthorized("User Is Not Logged In.");

            return File("/1.png", "image/png");
        }
    }
}
