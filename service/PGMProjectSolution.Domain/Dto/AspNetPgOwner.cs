using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.Dto
{
    public class AspNetPgOwner
    {
        [Key]
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required(ErrorMessage ="Email cannot be empty")]
        [Compare("Email")]
        public bool EmailConfirmed { get; set; }


        public string PhoneNumber { get; set; }

        public string UserType { get; set; }

    }
}
