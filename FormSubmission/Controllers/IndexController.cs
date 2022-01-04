using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
    {
    public class IndexController : Controller
        {
            [HttpGet("")]
            public IActionResult Index()
                {
                    return View();
                }

            [HttpPost("")]
            public IActionResult IndexPost(Form user)
                {
                    if(ModelState.IsValid) //check for errors 
                    {
                        return RedirectToAction("Success");
                    }
                    else
                    {
                        return View("Index");
                    }
                }

            [HttpGet("Success")]
            public IActionResult Success()
            {
                return View("Success");
            }

        }

    }
