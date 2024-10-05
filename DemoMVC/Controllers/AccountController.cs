namespace DemoMVC.Controllers
{
using Microsoft.AspNetCore.Mvc;
public class AccountContronller : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
}