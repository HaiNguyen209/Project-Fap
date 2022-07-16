using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Project.Model;
using System.Linq;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult IndexTeacher(string userName)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                return View();
            }else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        public IActionResult IndexStudent(string userName)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult IndexAdmin()
        {
            return View();

        }

    }
}
