using Microsoft.AspNetCore.Mvc;
using MVCModelBinding.Models;

namespace MVCModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student currStudent)
        {
            // If all data is valid
            if (ModelState.IsValid)
            {
                // Add student to database

                // Send user back to home page
                return RedirectToAction("Index", "Home");
            }

            // If all data is not valid, show user
            // same page- with errors
            return View(currStudent);
        }
    }
}
