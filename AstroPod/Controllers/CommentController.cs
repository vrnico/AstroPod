using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AstroPod.Models;

namespace AstroPod.Controllers
{
    public class CommentController : Controller
    {
        private readonly AstroPodDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(AstroPodDbContext context, UserManager<AppUser> userManager)
        {
            _db = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_db.Comments.Include(comments => comments.Content).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Comment comment)
        {
            comment.PostDate = DateTime.Now;
            comment.UserId = (this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var users = _db.Users;
            var user = _db.Users.FirstOrDefault(q => q.Id == comment.UserId);
            comment.User = user;

            _db.Comments.Add(comment);
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", "Content", new { id = comment.ContentId });
        }

        [HttpPost]
        public IActionResult Delete(Comment comment)
        {
            _db.Remove(comment);
            _db.SaveChanges();
            return RedirectToAction("Details", "Content");
        }

    }
}