using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PurchaseRequisition.Models;
using PurchaseRequisition.ViewModels;
using PurchaseRequisition.WebServiceAccess.Base;

namespace PurchaseRequisition.Controllers
{
    [Route("[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IWebApiCalls _webApiCalls;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(IWebApiCalls webApiCalls, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _webApiCalls = webApiCalls;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult AdminMenu()
        {
            return View();
        }
        
         [HttpGet]
        public async Task<IActionResult> ResetAccount()
        {
            var users = await _webApiCalls.GetUserAsync();

            return View(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> ChangePassword(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("ResetAccount", _userManager.Users);
            }

            var model = new UserWithPassword() { UserId = user.Id, Username = user.UserName, Email = user.Email };

            return View(model);
        }
    }
}