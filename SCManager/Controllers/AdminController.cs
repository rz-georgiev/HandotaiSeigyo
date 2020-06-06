﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data;
using SCManager.Data.Models;
using SCManager.ViewModels.Admin;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize(Roles = UserRights.Administrator)]
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController
        (
            IMapper mapper,
            UserManager<ApplicationUser> userManager
        )
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userManager.Users);
            var administrators = await _userManager.GetUsersInRoleAsync("Administrator");
            var administratorsIds = administrators.Select(x => x.Id).ToList();

            var model = new IndexViewModel { Users = _mapper.Map<IEnumerable<UserViewModel>>(users) };

            foreach (var user in model.Users)
                user.IsAdmin = administratorsIds.Contains(user.Id);

            return View(model);
        }

        public IActionResult SetUserRole(string userId, string role)
        {
            return Ok();
        }
    }
}