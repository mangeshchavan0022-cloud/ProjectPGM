using Microsoft.AspNetCore.Mvc;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.Dto;
using PGMProjectSolution.Domain.Models;

namespace PGMProjectSolution.Api.Controllers
{
    public class PgController : Controller
    {
        private readonly IAspPgOwnerService _aspPgOwnerService;
        public PgController(IAspPgOwnerService aspPgOwnerService) 
        {
            _aspPgOwnerService = aspPgOwnerService;            
        }

        public IActionResult Index()
        {
            var Model = new AspNetPgOwnerModelView
            {
               ListPgs = _aspPgOwnerService.GetAll(),
                AspNetPgOwner = new AspNetPgOwner()
            };

            return View(Model);
        }

        public ActionResult Create(AspNetPgOwner aspNetPgOwner)
        {
            int result=_aspPgOwnerService.Create(aspNetPgOwner);
            return View("Index");
        }

    }
}
