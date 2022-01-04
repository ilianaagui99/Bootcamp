using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using Monster.Models;
// Other using statements
namespace Monster.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }
     
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Monstruo> AllMonsters = _context.Monstruos.ToList();
            
            return View();
        }
    }
 }
