using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Small_task.Controllers
{
    public class HelloController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WelcomeString(string name)
        {
            ViewData["Message"]  = $"Welcome, {name}!";
            return View();
           
        }
    }
}
