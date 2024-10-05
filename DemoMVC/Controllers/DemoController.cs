
using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
    public class DemoController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(Student ps)
    {
        string str0utput="xin chao"+ ps.StudentId +"-"+ ps.FullName + ps.Adress;
        ViewBag.infoStudent=str0utput;
        return View();
    }
  
}


