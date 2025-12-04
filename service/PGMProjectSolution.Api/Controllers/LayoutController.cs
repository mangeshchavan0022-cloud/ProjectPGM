using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PGMProjectSolution.Application.Interfaces;

namespace PGMProjectSolutionApi.Controllers
{
    public class LayoutController : Controller
    {
        private readonly IUIMenuService _menuService;
        private readonly UserManager<IdentityUser> _userManager;

        public LayoutController(IUIMenuService menuService, UserManager<IdentityUser> userManager)
        {
            _menuService = menuService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Sidebar()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);

            var role = roles.FirstOrDefault();

            var menus = _menuService.GetMenusForRole(role);

            return PartialView("_Sidebar", menus);
        }
    }

}
