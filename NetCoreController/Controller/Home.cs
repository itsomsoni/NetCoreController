using Microsoft.AspNetCore.Mvc;

namespace NetCoreController.Controller
{
    [Controller] //sufixing Home Class As Controller
    public class Home
    {
        //all public method are called action in controller.
        [HttpGet]
        [Route("Home")]
        [Route("/")]
        public string Index()
        {
            return "WelCome To .NetCore Application.";
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
    }
}