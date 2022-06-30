using Microsoft.AspNetCore.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            //Role role = new Role(1, "Teacher");
            //Account acc = new Account(1, "hainv", "123123", role);
            return View();
        }

        [HttpPost]
        public IActionResult Add(Account acc)
        {
            if (ModelState.IsValid) //Model đc tạo ra mà k có lỗi
            {
                return RedirectToAction("Index", acc);
            }
            else
            {
               return View(acc);
            }
        }
    }
}
