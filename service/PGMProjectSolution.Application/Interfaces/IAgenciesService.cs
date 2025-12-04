using PGMProjectSolution.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Application.Interfaces
{
    public interface IAgenciesService
    {
        int Create(AspNetUserAgencyDto aspNetUserAgencyDto);

        int Update(AspNetUserAgencyDto aspNetUserAgencyDto);

        List<AspNetUserAgencyDto> GetAll();

        AspNetUserAgencyDto GetById(int AgencyId);
    }
}
