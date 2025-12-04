using Microsoft.AspNetCore.Mvc;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;

namespace PGMProjectSolution.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAspNetUsers _aspNetUsers;

        public HomeController(IAspNetUsers aspNetRoles)
        {
            _aspNetUsers = aspNetRoles;
        }



        public ActionResult Index()
        {
            return View();
        
        }

        public IActionResult Privacy()
        {
            return View();
        }




    }
}
