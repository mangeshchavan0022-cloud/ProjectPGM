using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.Models
{
    public class AspNetUsersModelView
    {
        public AspNetUserDto AspNetUsers { get; set; }

        public List<AspNetUserDto> ListUsers { get; set; }

    }
}
