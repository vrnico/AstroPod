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

namespace AstroPod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Equator equator = Sun.EquatorialCoordinate(DateTime.Now);
            Ecliptic mooquator = Moon.EclipticalCoordinate(DateTime.Now);
            Ecliptic merquator = Mercury.EclipticalCoordinate(DateTime.Now);
            Ecliptic vequator = Venus.EclipticalCoordinate(DateTime.Now);
            Ecliptic mequator = Mars.EclipticalCoordinate(DateTime.Now);
            Ecliptic jequator = Jupiter.EclipticalCoordinate(DateTime.Now);
            Ecliptic sequator = Saturn.EclipticalCoordinate(DateTime.Now);
            Ecliptic urquator = Uranus.EclipticalCoordinate(DateTime.Now);
            Ecliptic nequator = Neptune.EclipticalCoordinate(DateTime.Now);
            Ecliptic ecliptic = CoordinateSystem.Equatorial2Ecliptic(equator);
          
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
