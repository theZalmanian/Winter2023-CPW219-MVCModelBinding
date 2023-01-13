using Microsoft.AspNetCore.Mvc;

namespace MVCModelBinding.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
