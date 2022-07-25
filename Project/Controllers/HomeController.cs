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

        public IActionResult IndexAdmin(string searchText)
        {
            dynamic model = new ExpandoObject();

            model.Account = context.Accounts.ToList();
            model.Student = context.Students.ToList();
            model.Grade = context.Grades.ToList();

            model.Role = context.Roles.ToList();
            model.QuantityStudent = (from a in context.Accounts.ToList()
                                     where a.RoleId == 2
                                     select a).Count();
            model.QuantityTeacher = (from a in context.Accounts.ToList()
                                     where a.RoleId == 1
                                     select a).Count();
            //ViewBag.QuantityStudentOfEachGrade = (from a in context.Attendances.ToList()
            //                                    join g in context.Grades.ToList() on a.ClassId equals g.Id
            //                                    group g by g.ClassName into grg
            //                                    select grg.Count()).ToList();                                               
            if (searchText != null)
            {
                model.Account = from a in context.Accounts
                                where a.UserName.Contains(searchText)
                                select a;
            }
            return View(model);

        }

    }
}
