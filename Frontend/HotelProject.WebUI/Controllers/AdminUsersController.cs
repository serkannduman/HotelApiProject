using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
