using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AstroPod.Models;
using AstroAlgo;
using AstroAlgo.Base;
using AstroAlgo.SolarSystem;
using AstroAlgo.Model;
using AstroPod.Data;

namespace AstroPod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime birthday = new DateTime(1991, 6, 5, 8, 26, 00);
            Equator equator = Sun.EquatorialCoordinate(birthday);
            Ecliptic mooquator = Moon.EclipticalCoordinate(birthday);
            Ecliptic merquator = Mercury.EclipticalCoordinate(birthday);
            Ecliptic vequator = Venus.EclipticalCoordinate(birthday);
            Ecliptic mequator = Mars.EclipticalCoordinate(birthday);
            Ecliptic jequator = Jupiter.EclipticalCoordinate(birthday);
            Ecliptic sequator = Saturn.EclipticalCoordinate(birthday);
            Ecliptic urquator = Uranus.EclipticalCoordinate(birthday);
            Ecliptic nequator = Neptune.EclipticalCoordinate(DateTime.Now);
            Ecliptic ecliptic = CoordinateSystem.Equatorial2Ecliptic(equator);

            Debug.WriteLine(DateTime.Now);
            Debug.WriteLine("SUN" + ecliptic.Longitude);
            Debug.WriteLine("Moon" + mooquator.Longitude);
            Debug.WriteLine("MERC: " + merquator.Longitude);
            Debug.WriteLine("VENUS" + vequator.Longitude);
            Debug.WriteLine("Mars" + mequator.Longitude);
            Debug.WriteLine("Jup: " + jequator.Longitude);
            Debug.WriteLine("Saturn: " + sequator.Longitude);
            Debug.WriteLine("Urnuas: " + urquator.Longitude);
            Debug.WriteLine("Neptune: " + nequator.Longitude);

            return View();
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

    }
}
