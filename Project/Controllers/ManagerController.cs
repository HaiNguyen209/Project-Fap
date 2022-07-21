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
            if (ModelState.IsValid)
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            return RedirectToAction("IndexAdmin", "Home");

        }

        public IActionResult Edit()
        {
            return View();
        }
      
    }
}
