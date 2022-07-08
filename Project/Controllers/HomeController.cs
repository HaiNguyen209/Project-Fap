using Microsoft.AspNetCore.Mvc;
using Project.Model;
using System.Linq;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string userName)
        {
            ViewBag.userName = userName;
            return View();
        }
        public IActionResult IndexTeacher(string userName)
        {
            ViewBag.userName = userName;
            return View();
        }
        
        public IActionResult IndexStudent(string userName)
        {
            ViewBag.userName = userName;
            return View();
        }

    }
}
