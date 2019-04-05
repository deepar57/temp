using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class ActionTestController : Controller
    {
        public IActionResult Index()
        {
			//return Accepted();
			//return Ok();	

		return View();
        }
    }
}