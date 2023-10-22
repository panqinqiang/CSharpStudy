using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Demo1()  //Action方法，操作方法
        {
            //return View();
            Person p1 = new Person("杨中科242", true, DateTime.Now);
            return View(p1);
        }
    }
}
