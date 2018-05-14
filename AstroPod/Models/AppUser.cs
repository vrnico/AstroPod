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
        public string SunZod { get; set; }
        public double UserMoon { get; set; }
        public string MoonZod { get; set; }

        public AppUser() {
        }

        public  void SetZod()
        {
            if (UserSun >= 0 && UserSun <= 30)
            {
                SunZod = "Aries";
 }
            else if (UserSun >= 30 && UserSun <= 60)
            {
                SunZod = "Taurus";
          }
            else if (UserSun >= 60 && UserSun <= 90)
            {
                SunZod = "Gemini";
          }
            else if (UserSun >= 90 && UserSun <= 120)
            {
                SunZod = "Cancer";
          }
            else if (UserSun >= 120 && UserSun <= 150)
            {
                SunZod = "Leo";
          }
            else if (UserSun >= 150 && UserSun <= 180)
            {
                SunZod = "Virgo";
          }
            else if (UserSun >= 180 && UserSun <= 210)
            {
                SunZod = "Libra";
          }
            else if (UserSun >= 210 && UserSun <= 240)
            {
                SunZod = "Scorpio";
          }
            else if (UserSun >= 240 && UserSun <= 270)
            {
                SunZod = "Sagittarius";
          }
            else if (UserSun >= 270 && UserSun <= 300)
            {
                SunZod = "Capricorn";
          }
            else if (UserSun >= 300 && UserSun <= 330)
            {
                SunZod = "Aquarius";
          }
            else if (UserSun >= 330 && UserSun <= 360)
            {
                SunZod = "Pisces";
          }
        }

        public void SetMoonZod()
        {
            if (UserMoon >= 0 && UserMoon <= 30)
            {
                MoonZod = "Aries";
            }
            else if (UserMoon >= 30 && UserMoon <= 60)
            {
                MoonZod = "Taurus";
            }
            else if (UserMoon >= 60 && UserMoon <= 90)
            {
                MoonZod = "Gemini";
            }
            else if (UserMoon >= 90 && UserMoon <= 120)
            {
                MoonZod = "Cancer";
            }
            else if (UserMoon >= 120 && UserMoon <= 150)
            {
                MoonZod = "Leo";
            }
            else if (UserMoon >= 150 && UserMoon <= 180)
            {
                MoonZod = "Virgo";
            }
            else if (UserMoon >= 180 && UserMoon <= 210)
            {
                MoonZod = "Libra";
            }
            else if (UserMoon >= 210 && UserMoon <= 240)
            {
                MoonZod = "Scorpio";
            }
            else if (UserMoon >= 240 && UserMoon <= 270)
            {
                MoonZod = "Sagittarius";
            }
            else if (UserMoon >= 270 && UserMoon <= 300)
            {
                MoonZod = "Capricorn";
            }
            else if (UserMoon >= 300 && UserMoon <= 330)
            {
                MoonZod = "Aquarius";
            }
            else if (UserMoon >= 330 && UserMoon <= 360)
            {
                MoonZod = "Pisces";
            }
        }

        ///SETZOD Sets zodiac sign, SETDATA sets ecliptic coordinates!

        public void SetData()
        { 
            Equator equator = Sun.EquatorialCoordinate(BirthDate);
            Ecliptic ecliptic = CoordinateSystem.Equatorial2Ecliptic(equator);

            UserSun = ecliptic.Longitude;
        }

        public void SetMoonData()
        {
            Ecliptic moonquator = Moon.EclipticalCoordinate(BirthDate);
            UserMoon = moonquator.Longitude;
        }



    }
}