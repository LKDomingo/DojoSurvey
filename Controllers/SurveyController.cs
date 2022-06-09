using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; //This is a service that brings in our MVC functionality
using DojoSurvey.Models;

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
        ////////////////////////////
        [HttpPost("process")]
        public IActionResult Process(User newUser)
        {
            if(ModelState.IsValid)
        {
            // If we pass our validations, redirect to success page
        return RedirectToAction("Success", newUser);
        } else {
            // If we don't pass our validations render the index page again with errors
            return View("Index");
        }
        }
        ////////////////////////////
        [HttpGet("success")]
        public IActionResult Success(User newUser)
        {
            return View(newUser);
        }
    }
