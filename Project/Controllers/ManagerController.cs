using Microsoft.AspNetCore.Mvc;
using Project.Modelss;
using System.Linq;
using System.Dynamic;

namespace Project.Controllers
{
    public class ManagerController : Controller
    {
        ProjectFapContext context = new ProjectFapContext();

        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Account account)
        {
            if (ModelState.IsValid && isDuplicateAccount(account.UserName) == false)
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                return RedirectToAction("IndexAdmin", "Home");
            }
            else
            {
                ViewBag.Notify = " username Account is exist , don't create new Account";
                return View();

            }
        }
        [HttpGet]
      
        public bool isDuplidateGrade(string Id)
        {
            return context.Grades.Where(g => g.Id.Equals(Id)).Any();
        }
        public bool isDuplicateAccount(string username)
        {
            return context.Accounts.Where(a => a.UserName.Equals(username)).Any();
        }
        public IActionResult AddGrade()
        {
            return View();

        }
       
        [HttpPost]
        public IActionResult AddGrade(Grade grade)
        {
            if (isDuplidateGrade(grade.Id) == false)
            {
                context.Grades.Add(grade);
                context.SaveChanges();
                return RedirectToAction("IndexAdmin", "Home");
            }
            else
            {
                ViewBag.Notify = "Grade is exist , don't create new grade";
                return View();

            }

        }

        public IActionResult Edit(string username)
        {
            if(username != null)
            {
                var account = context.Accounts.Find(username);
                return View(account);
            }
            return View();

        }
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                context.Accounts.Update(account);
                context.SaveChanges();
            }
            return RedirectToAction("IndexAdmin", "Home");

        }

        public IActionResult Delete(string username)
        {
            var account = context.Accounts.Find(username);
            context.Accounts.Remove(account);
            context.SaveChanges();
            return RedirectToAction("IndexAdmin", "Home");
        }

        
        }
}
