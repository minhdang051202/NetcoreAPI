using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace FirstWebMVC.Controllers
{
    public class StudentController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
    public IActionResult Index(Student std)
    {
        string strResult = "Hello :" + std.StudentID + "-" + std.FullName ;
        ViewBag.Nhandulieu = strResult ; 
        return View();
    }
    
}
}