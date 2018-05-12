﻿using System;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AstroPod.Models;

namespace AstroPod.Data
{
    public class DbInitializer
    {
        public static void Initialize(AstroPodDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }


            var roles = new IdentityRole[]
            {
                new IdentityRole() { Name = "Admin" }

            };




            foreach (var r in roles)
            {
                context.Roles.Add(r);
            }






            context.SaveChanges();
        }
    }
}