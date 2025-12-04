using PGMProjectSolution.Domain.Dto;
using PGMProjectSolution.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.Models
{
    public class AspNetAgencyViewModel
    {
        public AspNetUserAgencyDto AgencyDto { get; set; }

        public List<AspNetUserAgencyDto> ListAgencies { get; set; }
    }
}
