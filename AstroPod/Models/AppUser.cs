using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Security.Claims;
using AstroPod.Models;
using AstroAlgo;
using AstroAlgo.Base;
using AstroAlgo.SolarSystem;
using AstroAlgo.Model;
using AstroPod.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace AstroPod.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public double UserSun { get; set;}

        public AppUser() {
        }

        public void SetData()
        { 
            Equator equator = Sun.EquatorialCoordinate(BirthDate);
            Ecliptic ecliptic = CoordinateSystem.Equatorial2Ecliptic(equator);
            

            UserSun = ecliptic.Longitude;
        }



    }
}