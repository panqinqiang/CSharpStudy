using ASPDotNETCoreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreWebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Demo1()
        {
            var model = new Person("Zack", true, new DateTime(1999, 3, 29));
            return View(model);
        }
    }
}
