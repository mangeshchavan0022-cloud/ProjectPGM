using Microsoft.AspNetCore.Mvc;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Models;
using PGMProjectSolution.Infrastructure.Context;

namespace PGMProjectSolution.Api.Controllers
{
    public class AgencyController : Controller
    {
        private readonly IAgenciesService _agenciesService;
        public AgencyController(IAgenciesService agenciesService) 
        {
            _agenciesService = agenciesService;            
        } 

 
        public IActionResult AddAgency()
        {
            var Model = new AspNetAgencyViewModel
            {
                ListAgencies = _agenciesService.GetAll(),
                AgencyDto = new AspNetUserAgencyDto()
            };
            return View();
        }
        public IActionResult Create(AspNetUserAgencyDto dto)
        {
            _agenciesService.Create(dto);
            return View("AddAgency");
        }

        
    }
}
