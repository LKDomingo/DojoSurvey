using Microsoft.AspNetCore.Mvc; //This is a service that brings in our MVC functionality
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!
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
        public IActionResult Process(string Name, string Location, string Language, string Comment)
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Location: {Location}");
            System.Console.WriteLine($"Language: {Language}");
            System.Console.WriteLine($"Comment: {Comment}");
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Success");
        }
    }
