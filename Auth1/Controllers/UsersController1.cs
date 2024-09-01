using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Studentcontroller.Data;
using Studentcontroller.Models;

namespace Studentcontroller.Controllers
{
    public class UsersController1 : Controller
    {
        private readonly ApplicationDbcontext context;

        public UsersController1(ApplicationDbcontext context)
        {
            this.context = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Add(user);
            context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login() { 
             return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var ckeckUser=context.Users.Where(x=>x.UserName == user.UserName && x.Password == user.Password).ToList();
            if( ckeckUser.Any() )
            {
                return RedirectToAction("Index","Employees");
            }
            return View(user);
        }
    }
}
