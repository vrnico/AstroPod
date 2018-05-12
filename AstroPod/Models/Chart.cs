using AstroAlgo.Base;
using AstroAlgo.Model;
using AstroAlgo.SolarSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AstroPod.Models
{
    public class Chart
    {
        private double _description;



        public Chart(double description)
        {
            _description = description;

        }

        public double GetDescription()
        {
            DateTime birthday = new DateTime(1991, 6, 5);

            Equator equator = Sun.EquatorialCoordinate(birthday);

            Ecliptic ecliptic = CoordinateSystem.Equatorial2Ecliptic(equator);
            Debug.WriteLine("FAAAAH" + ecliptic.Longitude);

            return ecliptic.Longitude;

        }
    }
    }
