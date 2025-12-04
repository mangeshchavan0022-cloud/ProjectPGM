using Microsoft.EntityFrameworkCore;
using PGMProjectSolution.Domain.Dto;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using PGMProjectSolution.Domain.Models;

namespace PGMProjectSolution.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AspNetUser> AspNetUsers { get; set; }

        public DbSet<AspNetPgOwner> AspNetPgOwner { get; set; }
        public DbSet<AspNetRole> AspNetRoles {get; set;}

        public DbSet<AspNetUserAgencyDto> Agencies{ get; set; }

        public DbSet<UIMenuDto> UIMenu { get; set; }
    }
}
