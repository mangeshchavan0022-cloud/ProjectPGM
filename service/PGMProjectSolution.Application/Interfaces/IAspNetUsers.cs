using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Application.Interfaces
{
    public interface IAspNetUsers
    {
        public int Create(AspNetUserDto aspNetRoles);

        public int Update(AspNetUserDto aspNetRoles);

        public List<AspNetUserDto> GetAll();

        public AspNetUserDto GetById(int RoleId);
    }
}
