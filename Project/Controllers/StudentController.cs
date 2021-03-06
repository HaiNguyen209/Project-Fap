using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Project.Model;
using System.IO;
using System;

namespace Project.Controllers
{
    public class StudentController : Controller
    {
        ProjectFapContext context = new ProjectFapContext();
        public IActionResult ViewProfile()
        {
            var username = HttpContext.Session.GetString("username");
            var Student = context.Students.Where(s => s.UserName.Equals(username)).FirstOrDefault();
            return View(Student);
        }

        public IActionResult Edit(string id)
        {
            var Student = context.Students.Where(s => s.Id.Equals(id)).FirstOrDefault();
            return View(Student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
             {
                context.Students.Update(student);
                context.SaveChanges();
                return RedirectToAction("ViewProfile");
            }
            return View(student);
        }

    }
}
