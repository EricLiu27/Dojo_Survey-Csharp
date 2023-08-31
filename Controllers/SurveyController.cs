
using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey.Controllers;
public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("Form");
    }
    [HttpPost("Submit")]
    public IActionResult Submit(string name, string location, string language, string comment)
    {
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View("Display");
    }

}

