using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore1_1_HiddenNameBug.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MyModel
            {
                Rows = new List<MyModelRow>
                {
                    new MyModelRow { IntProperty = 1, StringProperty = "A" },
                    new MyModelRow { IntProperty = 2, StringProperty = "B" },
                }
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
