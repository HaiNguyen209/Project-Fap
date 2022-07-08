using Microsoft.AspNetCore.Mvc;
using Project.Model;
using System.Linq;


namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Account account)
        {
            try
            {
                ProjectFapContext projectFapContext = new ProjectFapContext();

                var data = projectFapContext.Accounts.Where(a => a.UserName.Equals(account.UserName) && a.Password.Equals(account.Password)).ToList();

                account.RoleId = data[0].RoleId;

                if (data.Count() > 0)
                {
                    if (data[0].RoleId == 1)
                    {
                        return RedirectToAction("IndexTeacher", "Home", new { userName = account.UserName });
                    }
                    else
                    {
                        return RedirectToAction("IndexStudent", "Home", new { userName = account.UserName });
                    }
                }
                else
                {
                    ViewBag.messNotify = "Username or password error!";
                    return View();
                }
                  
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Login error: " + ex.Message);
            }
            return View();
        }
    }
}
