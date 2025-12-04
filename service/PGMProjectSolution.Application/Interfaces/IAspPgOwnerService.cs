using PGMProjectSolution.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Application.Interfaces
{
    public interface IAspPgOwnerService
    {
        int Create(AspNetPgOwner aspNetPgOwner);

        int Update(AspNetPgOwner aspNetPgOwner);

        List<AspNetPgOwner> GetAll();

        AspNetPgOwner GetById(int PgOwnerId);

    }
}
