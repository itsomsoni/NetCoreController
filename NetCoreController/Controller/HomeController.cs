using Microsoft.AspNetCore.Mvc;

namespace NetCoreController.Controller
{
    public class HomeController
    {
        //all public method are called action in controller.
        [Route("Home")]
        public string Index()
        {
            return "WelCome To .NetCore Application.";
        }
    }
}