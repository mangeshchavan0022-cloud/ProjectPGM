using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.Models;
using PGMProjectSolution.Infrastructure.Context;

namespace PGMProjectSolution.Application.Services
{
    public class UIMenuService: IUIMenuService
    {
        private readonly AppDbContext _context;
        public UIMenuService(AppDbContext context)
        {
            _context = context;
        }
        public List<UIMenuDto> GetMenusForRole(string role)
        {
            return _context.UIMenu
                .Where(x => x.RoleName == role)
                .Select(x => new UIMenuDto
                {
                    Id = x.Id,
                    RoleName = x.RoleName,
                    Menu = x.Menu,
                    SubMenu = "",
                    Controller = x.Controller,
                    Action = x.Action
                }).ToList();
        }


    }
}
