using Microsoft.AspNetCore.Mvc;
using NetCoreController.Models;

namespace NetCoreController.Controllers
{
    [Controller] //sufixing Home Class As Controller
    public class HomeController : Controller
    {
        //all public method are called action in controller.
        [HttpGet]
        [Route("Home")]
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h4>WelCome To .NetCore Application.</h4>", "text/html");

            /*return new ContentResult()
            {
                Content = "<h4>WelCome To .NetCore Application.</h4>",
                ContentType = "text/html"
            };*/
            //return "WelCome To .NetCore Application.";
        }
        [Route("About")]
        public string About()
        {
            return "WelCome To About Page.";
        }
        [Route("Contact-Us")]
        public string Contact()
        {
            return "WelCome To Contact Page.";
        }
        [Route("/Product/{id:int:min(1000):max(9999)}")]
        public string Product()
        {
            return "WelCome To Product Page.";
        }
        [Route("/Employee/Om")]
        public JsonResult Employee()
        {
            EmployeeModel employee = new() { EmployeeId = 22099, EmployeeName = "Om", Salary = 27500, Age = 22 };

            return Json(employee);
            //ContentResult
            //return Content("{\"name\": \"Om\"}", "application/json");
        }
    }
}