using Microsoft.AspNetCore.Mvc;
namespace Basics.Controllers{

    public class EmployeeController : Controller
    {
        public IActionResult Index1(){
            string message=$"Hello World.{DateTime.Now().ToString}";
            return View("Index1",message) ;
        }
        public ViewResult Index2(){
            return View("index");
        }
        public IActionResult Index3(){
            return  Content("Employee");
        }

    }
}