
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;
namespace DojoSurveyModel.Controllers     //be sure to use your own project's namespace!
{
    public class IndexController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
    
            return View();
        }
        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View("Result");
        }
                
        [HttpPost("Result")]
        public IActionResult ResultPost(Person person)
            {
                return View("Result", person);
            }
    }
}