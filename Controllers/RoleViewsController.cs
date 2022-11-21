using ASP.NETCoreIdentityCustom.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreIdentityCustom.Controllers
{
    public class RoleViewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireStudent)]
        public IActionResult Student()
        {
            return View();
        }

        [Authorize(Policy = "RequireTeacher")]
        public IActionResult Teacher()
        {
            return View();
        }
    }
}
