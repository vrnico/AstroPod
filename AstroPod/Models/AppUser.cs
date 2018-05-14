using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace AstroPod.Models
{
    public class AppUser : IdentityUser
    {


        public DateTime BirthDate { get; set; }
     
    }
}