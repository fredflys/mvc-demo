using Microsoft.AspNetCore.Mvc;

namespace mvc_demo
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}