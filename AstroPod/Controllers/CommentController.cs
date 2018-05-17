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
using System.Security.Claims;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AstroPod.Controllers
{
    public class CommentController : Controller
    {
        private readonly AstroPodDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public CommentController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AstroPodDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            string thisUser = _userManager.GetUserId(User);
            AppUser user = _db.Users.Where(u => u.Id == thisUser).FirstOrDefault();
            ViewBag.User = _db.Users.Where(u => u.Id == thisUser).FirstOrDefault();
            List<Comment> model = _db.Comments.OrderByDescending(x => x.PostDate).ToList();
            return PartialView(model);
          
        }

      
        public IActionResult New()
        {
            return View();
        }



        public IActionResult Add(string id)
        {
            ViewBag.User.SunZod = id;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> New(Comment comment)
        {
            comment.PostDate = DateTime.Now;
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            comment.User = await _userManager.FindByIdAsync(userId);
            string thisUser = _userManager.GetUserId(User);
            ViewBag.User = _db.Users.Where(u => u.Id == thisUser).FirstOrDefault();
            _db.Comments.Add(comment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _db.Comments.Remove(_db.Comments.FirstOrDefault(i => i.CommentId == id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        //Ajax call is made in the controller here
        public IActionResult HelloAjax()
        {
            return Json(_db.Comments.ToList());
        }
    }
}



//    public class CommentController : Controller
//    {
//        private readonly AstroPodDbContext _db;
//        private readonly UserManager<AppUser> _userManager;

//        public CommentController(AstroPodDbContext context, UserManager<AppUser> userManager)
//        {
//            _db = context;
//            _userManager = userManager;
//        }

//        public IActionResult Index()
//        {
//            return View(_db.Comments.Include(comments => comments.Content).ToList());
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }


//        [HttpPost]
//        public async Task<IActionResult> Create(Comment comment)
//        {
//            comment.PostDate = DateTime.Now;
//            comment.UserId = (this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
//            var users = _db.Users;
//            var user = _db.Users.FirstOrDefault(q => q.SunId == comment.SunId);
//            _db.Comments.Add(comment);
//            await _db.SaveChangesAsync();
//            return RedirectToAction("Details", "Content", new { id = comment.SunId });
//        }

//        [HttpPost]
//        public IActionResult Delete(Comment comment)
//        {
//            _db.Remove(comment);
//            _db.SaveChanges();
//            return RedirectToAction("Details", "Content");
//        }

//    }
//}