using Microsoft.AspNetCore.Mvc;

namespace Studentcontroller.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Getall()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult index()
        {
            return View();
        }
    }
}
