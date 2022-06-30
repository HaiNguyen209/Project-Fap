using Microsoft.AspNetCore.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            Account account = new Account();
            return View(account);
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            if (ModelState.IsValid)  return View(account);
            else return View(account);
        }
    }
}
