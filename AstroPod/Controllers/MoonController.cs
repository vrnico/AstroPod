using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AstroPod.Models;
using System.Security.Principal;
using AstroAlgo.Model;
using AstroAlgo.SolarSystem;
using AstroAlgo.Base;
using System.Diagnostics;


namespace AstroPod.Controllers
{
    public class MoonController : Controller
    {
        private readonly AstroPodDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public MoonController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AstroPodDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        [HttpGet("/Moon/{id}")]
        public IActionResult Index(int id)
        {
            string thisUser = _userManager.GetUserId(User);
            AppUser user = _db.Users.Where(u => u.Id == thisUser).FirstOrDefault();
            ViewBag.User = _db.Users.Where(u => u.Id == thisUser).FirstOrDefault();
            List<AppUser> moonMatches = _db.Users.Where(u => u.MoonZod == user.MoonZod).ToList();
            AstroPod.Models.Content.SetList();
            var contentPlacements = AstroPod.Models.Content.Placements;
            string[] placement = AstroPod.Models.Content.Placements[id];



            return View(moonMatches);
        }
    }
}