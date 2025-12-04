using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Application.Services
{
    public class AgencyService : IAgenciesService
    {
        private readonly AppDbContext _appDbContext;
        public AgencyService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public int Create(AspNetUserAgencyDto aspNetUserAgencyDto)
        {
            AspNetUserAgencyDto agency = new AspNetUserAgencyDto();
            agency.AgencyId = Guid.NewGuid().ToString();
            agency.UserId = aspNetUserAgencyDto.UserId;
            agency.AgencyName = aspNetUserAgencyDto.AgencyName;
            agency.AgencyType = aspNetUserAgencyDto.AgencyType;
            agency.Email = aspNetUserAgencyDto.Email;
            agency.Documents = aspNetUserAgencyDto.Documents;
            agency.Address = aspNetUserAgencyDto.Address;
            agency.ContactPerson = aspNetUserAgencyDto.ContactPerson;
            agency.MobileNumber = aspNetUserAgencyDto.MobileNumber;
            agency.CreatedBy = aspNetUserAgencyDto.CreatedBy;
            agency.CreatedOn = DateTime.Now;

            _appDbContext.Add(agency);
            _appDbContext.SaveChanges();
            return 1;
        }

        public List<AspNetUserAgencyDto> GetAll()
        {
            List<AspNetUserAgencyDto> ListAgencies=_appDbContext.Agencies.ToList();
            return ListAgencies;
        }

        public AspNetUserAgencyDto GetById(int AgencyId)
        {
            AspNetUserAgencyDto dto =_appDbContext.Agencies.Find(AgencyId);

            if (dto == null)
                return null;

            return dto;
        }

        public int Update(AspNetUserAgencyDto aspNetUserAgencyDto)
        {
            AspNetUserAgencyDto Agency = _appDbContext.Agencies.Find(aspNetUserAgencyDto.AgencyId);

            if (Agency == null)
                return 0;

            Agency.AgencyName = aspNetUserAgencyDto.AgencyName;
            Agency.Address = aspNetUserAgencyDto.Address;
            Agency.MobileNumber = aspNetUserAgencyDto.MobileNumber;
            Agency.AgencyType= aspNetUserAgencyDto.AgencyType;
            Agency.Email = aspNetUserAgencyDto.Email;
            Agency.ContactPerson = aspNetUserAgencyDto.ContactPerson;
            
            _appDbContext.Update(Agency);
            _appDbContext.SaveChanges();
            return 1;
        }
    }
}
