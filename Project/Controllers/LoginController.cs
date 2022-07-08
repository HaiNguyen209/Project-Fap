using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Project.Model;
using System.Linq;


namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string s)
        {
            HttpContext.Session.SetString("username", "");
            return View();
        }
      
        [HttpPost]
        public IActionResult Index(Account account)
        {
           
            try
            {
                if (ModelState.IsValid)
                {
                    ProjectFapContext projectFapContext = new ProjectFapContext();

                    var data = projectFapContext.Accounts.Where(a => a.UserName.Equals(account.UserName) && a.Password.Equals(account.Password)).ToList();

                    if (data.Count() > 0)
                    {
                        HttpContext.Session.SetString("username", account.UserName);
                        if (data[0].RoleId == 1)
                        {
                            return RedirectToAction("IndexTeacher", "Home");
                        }
                        else
                        {
                            return RedirectToAction("IndexStudent", "Home");
                        }
                    }
                    else
                    {
                        ViewBag.messNotify = "Username or password error!";
                        return View();
                    }
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
