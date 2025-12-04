using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Application.Interfaces
{
    public interface IAspNetRole
    {
        int Create(AspNetRoleDto aspNetRoleDto);

        int Update(AspNetRoleDto aspNetRoleDto);

        List<AspNetRoleDto> GetAll();

        AspNetRoleDto GetById(int RoleId);
    }
}
