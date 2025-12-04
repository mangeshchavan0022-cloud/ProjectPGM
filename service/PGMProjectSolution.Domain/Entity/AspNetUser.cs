using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.Entity
{
    public class AspNetUser
    {
        [Key]
        public string? Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset LockoutEnd { get; set; } = DateTimeOffset.Now;
        public bool LockoutEnabled { get; set; } = true;
        public int AccessFailedCount { get; set; }

        public string AdminUser { get; set; } = string.Empty;
        public string CheckAdmin { get; set; } = string.Empty;
    }

}


