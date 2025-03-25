using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task1.Models;
using Task1.ViewModels;

namespace Task1.Controllers
{
    [Authorize(Roles = "SystemAdministrator")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(user => new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FisrtName,
                LastName = user.LastName,
                Email = user.Email,
                AccountStatus = user.AccountStatus,
                UserRole = _userManager.GetRolesAsync(user).Result
            }).ToListAsync();
            return View(users);
        }
        //public async Task<IActionResult> Add()
        //{

        //}
    }
}
