using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

/*
MCronberg.CSCourseHelper.Standard (NuGET)

Brug feks 

IPersonRepository rep = new PersonRepositoryStatic();
var listeAfPersoner = rep.GetPeople();

eller blot

var listeAfPersoner = PersonRepositoryRandom.JustGetPeople();

*/
using MCronberg;

namespace Company.WebApp1.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View();
        }

        /* 
        
        Eller async

        [HttpGet("~/")]
        public async Task<IActionResult> Index()
        {          
            await Task.Delay(10);
            return View();
        }
        */

    }
}
