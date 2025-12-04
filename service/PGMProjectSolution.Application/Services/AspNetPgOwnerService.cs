using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.Dto;
using PGMProjectSolution.Infrastructure.Context;

namespace PGMProjectSolution.Application.Services
{
    public class AspNetPgOwnerService : IAspPgOwnerService
    {
        private readonly AppDbContext _appDbContext;
        public AspNetPgOwnerService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public int Create(AspNetPgOwner dto)
        {

            AspNetPgOwner PgOwner = new AspNetPgOwner();
            PgOwner.Id = Guid.NewGuid().ToString();
            PgOwner.FullName = dto.FullName??"";
            PgOwner.UserName = dto.UserName;
            PgOwner.PhoneNumber = dto.PhoneNumber;
            PgOwner.Email = dto.Email??"";
            PgOwner.EmailConfirmed = true;

            _appDbContext.AspNetPgOwner.Add(PgOwner);
            _appDbContext.SaveChanges();
            return 0;
        }

        public List<AspNetPgOwner> GetAll()
        {
            List<AspNetPgOwner> ListPgOwners = _appDbContext.AspNetPgOwner.ToList<AspNetPgOwner>();
            return ListPgOwners;
        }

        public AspNetPgOwner GetById(int PgOwnerId)
        {
            var owner = _appDbContext.AspNetPgOwner.Find(PgOwnerId);

            if (owner == null)
            {
                return new AspNetPgOwner();
            }

            return owner;
        }

        public int Update(AspNetPgOwner aspNetPgOwner)
        {
            var owner = _appDbContext.AspNetPgOwner.Find(aspNetPgOwner.Id);

            if (owner == null)
            {
                return 0;
            }

            owner.Id = aspNetPgOwner.Id;
            owner.FullName = aspNetPgOwner.FullName;
            owner.UserName = aspNetPgOwner.UserName;
            owner.PhoneNumber = aspNetPgOwner.PhoneNumber;
            owner.Email = aspNetPgOwner.Email;
            owner.EmailConfirmed = aspNetPgOwner.EmailConfirmed;
            owner.UserType = aspNetPgOwner.UserType;

            _appDbContext.Update(aspNetPgOwner);
            _appDbContext.SaveChanges();
            return 1;
        }
    }
}
