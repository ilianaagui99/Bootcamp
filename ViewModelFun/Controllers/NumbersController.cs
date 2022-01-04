using Microsoft.AspNetCore.Mvc; 
using ViewModelFun.Models; 

namespace ViewModelFun.Controllers
{
    public class NumbersController: Controller
    {
        [HttpGet]
        [Route("/numbers")]
        public IActionResult DisplayNumbers()
        {
            int[] arr = new int[]
            {
                1,2,3,4,5
            }; 

            return View("Numbers", arr);
        }

    }

}