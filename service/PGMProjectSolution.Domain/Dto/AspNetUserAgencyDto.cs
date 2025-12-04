using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.DTO
{
    public class AspNetUserAgencyDto
    {
        [Key]
        public string AgencyId { get; set; }

        public string AgencyName { get; set; }

        public string AgencyType { get; set; } = string.Empty;

        public string ContactPerson { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string? Documents { get; set; }

        public bool IsActive { get; set; } 
        public string UserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

    }
}
