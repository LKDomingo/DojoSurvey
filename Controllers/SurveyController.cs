using Microsoft.AspNetCore.Mvc; //This is a service that brings in our MVC functionality
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!
using DojoSurvey.Models;
    public class SurveyController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            // We don't need to put the name of the file in our View() if the filename matches the Acion name above.
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(User newUser)
        {
            return View("Success", newUser);
        }
    }
