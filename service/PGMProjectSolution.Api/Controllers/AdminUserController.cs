using Microsoft.AspNetCore.Mvc;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Domain.DTO;
using PGMProjectSolution.Domain.Entity;
using PGMProjectSolution.Domain.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace PGMProjectSolution.Api.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly IAspNetUsers _aspNetUsers;
        public AdminUserController(IAspNetUsers aspNetUsers)
        {
            _aspNetUsers = aspNetUsers;
        }

        public IActionResult Index()
        {
            var Model = new AspNetUsersModelView
            {
                ListUsers = _aspNetUsers.GetAll(),
                AspNetUsers = new AspNetUserDto()
            };

            return View(Model);
        }

        //[HttpGet]
        public IActionResult Create(AspNetUserDto aspNetUserDto)
        {
            int result = _aspNetUsers.Create(aspNetUserDto);
            return RedirectToAction("AddProductOwner"); ;
        }


        //[HttpGet]
        public IActionResult AddProductOwner()
        {
            var Model = new AspNetUsersModelView
            {
                ListUsers = _aspNetUsers.GetAll(),
                AspNetUsers = new AspNetUserDto()
            };

            return View(Model);

        }

       


        
    }
}
