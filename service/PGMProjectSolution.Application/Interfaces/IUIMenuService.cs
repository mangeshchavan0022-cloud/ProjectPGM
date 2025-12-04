using PGMProjectSolution.Domain.Models;

namespace PGMProjectSolution.Application.Interfaces
{
    public interface IUIMenuService 
    {
        public List<UIMenuDto> GetMenusForRole(string role);

    }
}
