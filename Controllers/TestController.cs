using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Calculate(Models.TestModel tm)
        {
            var an = new Models.AnswerModel();
            an.Ann = tm.val1 + tm.val2;

            return View("Answer", an);
        }
    }
}
