using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models; 
namespace ViewModelFun.Controllers     //be sure to use your own project's namespace!
{
    public class MessageController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/")]     //associated route string (exclude the leading /)
        public IActionResult DisplayMessage()
        {
            Message message = new Message(); 
            message.YourMessage = "I love going out to dance :)"; 
           
            return View("Message", message);
        }


        


    }

}