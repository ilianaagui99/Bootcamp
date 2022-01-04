using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models; 
using System.Collections.Generic;

namespace ViewModelFun.Controllers     //be sure to use your own project's namespace!
{
    public class UserController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("/user")]     //associated route string (exclude the leading /)
        public IActionResult UserInfo()
        {
            User person = new User()
            {
                FirstName = "Iliana",
                LastName = "Aguilar"
            };
            return View("User",person);
        }

        [HttpGet]
        [Route("/users")]
        public IActionResult DisplayUserList()
        {
            List<User> userList = new List<User>()
            {
                new User()
                {
                    FirstName = "Grizel",
                    LastName = "Cornejo"
                },

                new User()
                {
                    FirstName = "Jocelyn",
                    LastName = "Cornejo"
                },

                new User()
                {
                    FirstName = "Gracie",
                    LastName = "Anaya"
                },

                new User()
                {
                    FirstName = "Leslie",
                    LastName = "Delarosa"
                },

            };
            return View("Users", userList); 

        }
    }
}