using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AstroPod.Models;
using AstroPod.ViewModels;
using AstroPod.Data;
using AstroAlgo.Model;
using AstroAlgo.SolarSystem;
using AstroAlgo.Base;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace AstroPod.Controllers
{
    public class AccountController : Controller
    {
        private readonly AstroPodDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AstroPodDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            string id = _userManager.GetUserId(User);
            return View(_db.Users.Where(u => u.Id == id).FirstOrDefault());
        }

        public IActionResult Register()
        {
            ViewBag.Roles = _db.Roles.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            AppUser user = new AppUser { UserName = model.UserName, Email = model.Email, BirthDate = model.BirthDate};
            user.Roles.Add(new IdentityUserRole<string> { RoleId = Request.Form["role"] });
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            user.SetData();
            user.SetZod();
            user.SetMoonData();
            user.SetMoonZod();
            user.SetMercData();
            user.SetMercZod();
            user.SetVenusData();
            user.SetVenusZod();
            user.SetMarsData();
            user.SetMarsZod();
            user.SetJupiterData();
            user.SetJupiterZod();
            user.SetSaturnData();
            user.SetSaturnZod();
            user.SetUranusData();
            user.SetUranusZod();
            user.SetNeptuneData();
            user.SetNeptuneZod();
            _db.SaveChanges();



            if (result.Succeeded)
                return RedirectToAction("Index");

            else
                return RedirectToAction("Register");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
                return RedirectToAction("Index");
            else
                return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }




    }
}
