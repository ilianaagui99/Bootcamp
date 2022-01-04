using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SimpleLogin.Models;


namespace SimpleLogin.Controllers
{
    public class IndexController : Controller
        {
            [HttpGet("")]
            public IActionResult Index()
                {
                    return View();
                }

            [HttpPost("Login")]
            public IActionResult Login(Login newLogin)
                {
                    if(ModelState.IsValid)
                        {
                            return RedirectToAction("Success");
                        }
                        return View("Index");
                }

            [HttpPost("Registration")]
            public IActionResult Registration(Registration newAccount)
                {
                    if(ModelState.IsValid)
                        {
                            return RedirectToAction("Success");
                        }
                     return View("Index");
                }

            [HttpGet("Success")]
            public IActionResult Success()
                {
                    return View("Success");
                }
        }
}