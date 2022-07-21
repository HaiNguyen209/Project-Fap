using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Project.Modelss;
using System.Linq;
using System.Dynamic;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        ProjectFapContext context = new ProjectFapContext();

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
            dynamic model = new ExpandoObject();

            model.Account = context.Accounts.ToList();
            model.Student = context.Students.ToList(); 
            model.Role = context.Roles.ToList();
            return View(model);

        }
        [HttpGet]
        public IActionResult IndexAdmin(string searchText)
        {
            dynamic model = new ExpandoObject();

            model.Account = context.Accounts.ToList();
            model.Student = context.Students.ToList();
            model.Role = context.Roles.ToList();

            if(searchText != null)
            {
                model.Account = from a in context.Accounts
                                where a.UserName.Contains(searchText)
                                select a;
            }

            return View(model);

        }

    }
}
