using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using PGMProjectSolution.Infrastructure.Context;
using System.Data;

namespace PGMProjectSolution.Application.Services
{
    public class AspNetRoleService : IAspNetRole
    {
        private readonly AppDbContext _appDbContext;
        public AspNetRoleService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int Create(AspNetRoleDto aspNetRoleDto)
        {
            AspNetRole aspNetRole = new AspNetRole();
            aspNetRole.RoleId = aspNetRoleDto.RoleId;
            aspNetRole.Name = aspNetRoleDto.UserName;
            aspNetRole.NormalizedName = aspNetRoleDto.UserName.ToUpper();
            aspNetRole.ConcurrencyStamp="";

            _appDbContext.Add(aspNetRole);
            _appDbContext.SaveChanges();
            return 1;
        }

        public List<AspNetRoleDto> GetAll()
        {
            List<AspNetRoleDto> ListRoles = _appDbContext.AspNetRoles.Select(r => new AspNetRoleDto
            {
                RoleId = r.RoleId,
                UserName = r.Name
            }).ToList();

            return ListRoles;
        }


        public AspNetRoleDto GetById(int RoleId)
        {
            AspNetRole aspNetRole = _appDbContext.AspNetRoles.Find(RoleId);

            if (aspNetRole == null)
            {
                return new AspNetRoleDto();
            }
            //Dto=ObjectSelectedProperties
            AspNetRoleDto dto = new AspNetRoleDto();
            dto.RoleId = aspNetRole.RoleId;
            dto.UserName = aspNetRole.Name;
            return dto;
        }

        public int Update(AspNetRoleDto aspNetRoleDto)
        {
            AspNetRole aspNetRole = _appDbContext.AspNetRoles.Find(aspNetRoleDto.RoleId);
            aspNetRole.RoleId = aspNetRoleDto.RoleId;
            aspNetRole.Name = aspNetRoleDto.UserName;
            aspNetRole.NormalizedName = aspNetRoleDto.UserName.ToUpper();
            aspNetRole.ConcurrencyStamp = Guid.NewGuid().ToString();

            _appDbContext.Update(aspNetRole);
            _appDbContext.SaveChanges();
            return 1;
        }
    }
}
