using Microsoft.AspNetCore.Mvc;

namespace MVCRoleTop.Controllers
{
    public class LocalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}