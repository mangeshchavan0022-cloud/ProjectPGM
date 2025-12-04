using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using PGMProjectSolution.Infrastructure.Context;
using System.ComponentModel.DataAnnotations;

namespace PGMProjectSolution.Application.Services
{
    public class AspNetUsersService : IAspNetUsers
    {
        private readonly AppDbContext _appDbContext;
        public AspNetUsersService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;            
        }

        public int Create(AspNetUserDto aspNetUserDto)
        {
            AspNetUser aspNetRoles = new AspNetUser();
            aspNetRoles.Id = Guid.NewGuid().ToString();
            aspNetRoles.FullName = aspNetUserDto.FullName;
            aspNetRoles.UserName = aspNetUserDto.UserName;
            aspNetRoles.NormalizedUserName =aspNetUserDto.UserName.ToLower();
            aspNetRoles.Email = aspNetUserDto.Email;
            aspNetRoles.NormalizedEmail = aspNetUserDto.Email.ToLower();
            aspNetRoles.EmailConfirmed = true;
            aspNetRoles.PasswordHash = "";
            aspNetRoles.SecurityStamp = "";
            aspNetRoles.ConcurrencyStamp = "";
            aspNetRoles.PhoneNumber = aspNetUserDto.PhoneNumber;
            aspNetRoles.PhoneNumberConfirmed = true;
            aspNetRoles.TwoFactorEnabled = true;
            _appDbContext.Add(aspNetRoles);
            _appDbContext.SaveChanges();
            return 1;
        }

        public List<AspNetUserDto> GetAll()
        {
            List<AspNetUserDto> ListUsers = _appDbContext.AspNetUsers.Select(r => new AspNetUserDto
            {
                FullName = r.FullName,
                UserName = r.UserName,
                Email = r.Email,
                PhoneNumber = r.PhoneNumber
            }).ToList();

            return ListUsers;
        }

        public AspNetUserDto GetById(int RoleId)
        {
            AspNetUserDto aspNetUserDto = new AspNetUserDto();
            var aspNetUser=_appDbContext.AspNetUsers.Find(RoleId);

            if(aspNetUser == null)
            {
                return new AspNetUserDto();
            }
            else
            {
                aspNetUserDto.FullName = aspNetUser.FullName;
                aspNetUserDto.PhoneNumber = aspNetUser.PhoneNumber;
                aspNetUserDto.Email = aspNetUser.Email;
                aspNetUserDto.UserName = aspNetUser.UserName;
            }

            return aspNetUserDto;
        }

        public int Update(AspNetUserDto aspNetUserDto)
        {
            AspNetUser aspNetUser = new AspNetUser();
            aspNetUser.FullName = aspNetUserDto.FullName;
            aspNetUser.UserName = aspNetUserDto.UserName;
            aspNetUser.NormalizedUserName = aspNetUserDto.UserName.ToLower();
            aspNetUser.Email = aspNetUserDto.Email;
            aspNetUser.NormalizedEmail = aspNetUserDto.Email.ToLower();
            aspNetUser.EmailConfirmed = true;
            aspNetUser.PasswordHash = "";
            aspNetUser.SecurityStamp = "";
            aspNetUser.ConcurrencyStamp = "";
            aspNetUser.PhoneNumber = aspNetUserDto.PhoneNumber;
            aspNetUser.PhoneNumberConfirmed = true;
            aspNetUser.TwoFactorEnabled = true;
            _appDbContext.Update(aspNetUser);
            _appDbContext.SaveChanges();
            return 1;
        }
    }
}
