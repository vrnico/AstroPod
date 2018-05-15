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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AstroPod.Controllers
{
    public class ContentController : Controller
    {
        private readonly AstroPodDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ContentController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AstroPodDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            string id = _userManager.GetUserId(User);
            AppUser user = _db.Users.Where(u => u.Id == id).FirstOrDefault();
            ViewBag.User = _db.Users.Where(u => u.Id == id).FirstOrDefault();
            List<AppUser> sunMatches = _db.Users.Where(u => u.SunZod == user.SunZod).ToList();
           
            return View(sunMatches);
        }



        [Authorize(Roles = "Admin")]
        public IActionResult New()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult New(Content content)
        {

            _db.Content.Add(content);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Add(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddConfirmed(int id)
        {
            Content content = _db.Content.FirstOrDefault(i => i.ContentId == id);
            content.Title = Request.Form["title"];
            content.Description = Request.Form["description"];
            content.Description = Request.Form["image"];
            _db.Entry(content).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _db.Content.Remove(_db.Content.FirstOrDefault(i => i.ContentId == id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult HelloAjax()
        {
            return Json(_db.Content.ToList());
        }
    }
}

