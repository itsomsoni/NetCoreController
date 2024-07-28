using Microsoft.AspNetCore.Mvc;
using NetCoreController.Models;

namespace NetCoreController.Controllers
{
    public class BookController : Controller
    {
        //-/Books?BookId=200&Author=OmSoni
        [Route("Books/{BookId?}/{Author?}")]
        //public IActionResult Book([FromRoute] int BookId, [FromQuery] string Author)
        public IActionResult Book(Books books)
        {
            if (!ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string ErrorMessageDisplay = string.Join(Environment.NewLine, errors);
                return BadRequest(ErrorMessageDisplay);
            }

            return Content($"BookdId = {books.BookId}, Author = {books.Author}", "text/plain");

            //StatusCode = 301 - Moved Permanently
            //StatusCode = 302 - Moved Temp.
            //return new RedirectToActionResult("Books", "Store", null, permanent: true);

            //int id = Convert.ToInt32(Request.Query["BookId"]);
            //bool IsLogged = Convert.ToBoolean(Request.Query["IsLogged"]);
            //return new LocalRedirectResult($"/Category/Books/{id}/{IsLogged}");

            //return new RedirectResult("https://github.com/");

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
