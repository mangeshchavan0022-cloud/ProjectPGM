using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGMProjectSolution.Domain.Models
{
    public class UIMenuDto
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<UIMenuDto> Menu { get; set; }

        public string SubMenu { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }


    }
}
