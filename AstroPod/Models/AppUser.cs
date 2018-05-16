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
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace AstroPod.Models
{


    public class AppUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public double UserSun { get; set;}
        public string SunZod { get; set; }
        public int SunId { get; set; }
        public int MoonId { get; set; }
        public double UserMoon { get; set; }
        public string MoonZod { get; set; }
        public double UserMerc{ get; set; }
        public string MercZod { get; set; }
        public double UserVenus { get; set; }
        public string VenusZod { get; set; }
        public double UserMars { get; set; }
        public string MarsZod { get; set; }
        public double UserJupiter { get; set; }
        public string JupiterZod { get; set; }
        public double UserSaturn { get; set; }
        public string SaturnZod { get; set; }
        public double UserUranus { get; set; }
        public string UranusZod { get; set; }
        public double UserNeptune { get; set; }
        public string NeptuneZod { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    


        public AppUser() {
        }

        public  void SetZod()
        {
            if (UserSun >= 0 && UserSun <= 30)
            {
                SunZod = "Aries";
                SunId = 0;
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
        
        //MOON

        public void SetMoonZod()
        {
            if (UserMoon >= 0 && UserMoon <= 30)
            {
                MoonZod = "Aries";
                MoonId = 2;
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
                MoonId = 64;
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

        //MERCURY

        public void SetMercZod()
        {
            if (UserMerc >= 0 && UserMerc <= 30)
            {
                MercZod = "Aries";
            }
            else if (UserMerc >= 30 && UserMerc <= 60)
            {
                MercZod = "Taurus";
            }
            else if (UserMerc >= 60 && UserMerc <= 90)
            {
                MercZod = "Gemini";
            }
            else if (UserMerc >= 90 && UserMerc <= 120)
            {
                MercZod = "Cancer";
            }
            else if (UserMerc >= 120 && UserMerc <= 150)
            {
                MercZod = "Leo";
            }
            else if (UserMerc >= 150 && UserMerc <= 180)
            {
                MercZod = "Virgo";
            }
            else if (UserMerc >= 180 && UserMerc <= 210)
            {
                MercZod = "Libra";
            }
            else if (UserMerc >= 210 && UserMerc <= 240)
            {
                MercZod = "Scorpio";
            }
            else if (UserMerc >= 240 && UserMerc <= 270)
            {
                MercZod = "Sagittarius";
            }
            else if (UserMerc >= 270 && UserMerc <= 300)
            {
                MercZod = "Capricorn";
            }
            else if (UserMerc >= 300 && UserMerc <= 330)
            {
                MercZod = "Aquarius";
            }
            else if (UserMerc >= 330 && UserMerc <= 360)
            {
                MercZod = "Pisces";
            }
        }

        //VENUS

        public void SetVenusZod()
        {
            if (UserVenus >= 0 && UserVenus <= 30)
            {
                VenusZod = "Aries";
            }
            else if (UserVenus >= 30 && UserVenus <= 60)
            {
                VenusZod = "Taurus";
            }
            else if (UserVenus >= 60 && UserVenus <= 90)
            {
                VenusZod = "Gemini";
            }
            else if (UserVenus >= 90 && UserVenus <= 120)
            {
                VenusZod = "Cancer";
            }
            else if (UserVenus >= 120 && UserVenus <= 150)
            {
                VenusZod = "Leo";
            }
            else if (UserVenus >= 150 && UserVenus <= 180)
            {
                VenusZod = "Virgo";
            }
            else if (UserVenus >= 180 && UserVenus <= 210)
            {
                VenusZod = "Libra";
            }
            else if (UserVenus >= 210 && UserVenus <= 240)
            {
                VenusZod = "Scorpio";
            }
            else if (UserVenus >= 240 && UserVenus <= 270)
            {
                VenusZod = "Sagittarius";
            }
            else if (UserVenus >= 270 && UserVenus <= 300)
            {
                VenusZod = "Capricorn";
            }
            else if (UserVenus >= 300 && UserVenus <= 330)
            {
                VenusZod = "Aquarius";
            }
            else if (UserVenus >= 330 && UserVenus <= 360)
            {
                VenusZod = "Pisces";
            }
        }

        //MARS

        public void SetMarsZod()
        {
            if (UserMars >= 0 && UserMars <= 30)
            {
                MarsZod = "Aries";
            }
            else if (UserMars >= 30 && UserMars <= 60)
            {
                MarsZod = "Taurus";
            }
            else if (UserMars >= 60 && UserMars <= 90)
            {
                MarsZod = "Gemini";
            }
            else if (UserMars >= 90 && UserMars <= 120)
            {
                MarsZod = "Cancer";
            }
            else if (UserMars >= 120 && UserMars <= 150)
            {
                MarsZod = "Leo";
            }
            else if (UserMars >= 150 && UserMars <= 180)
            {
                MarsZod = "Virgo";
            }
            else if (UserMars >= 180 && UserMars <= 210)
            {
                MarsZod = "Libra";
            }
            else if (UserMars >= 210 && UserMars <= 240)
            {
                MarsZod = "Scorpio";
            }
            else if (UserMars >= 240 && UserMars <= 270)
            {
                MarsZod = "Sagittarius";
            }
            else if (UserMars >= 270 && UserMars <= 300)
            {
                MarsZod = "Capricorn";
            }
            else if (UserMars >= 300 && UserMars <= 330)
            {
                MarsZod = "Aquarius";
            }
            else if (UserMars >= 330 && UserMars <= 360)
            {
                MarsZod = "Pisces";
            }
        }

        //JUPITER

        public void SetJupiterZod()
        {
            if (UserJupiter >= 0 && UserJupiter <= 30)
            {
                JupiterZod = "Aries";
            }
            else if (UserJupiter >= 30 && UserJupiter <= 60)
            {
                JupiterZod = "Taurus";
            }
            else if (UserJupiter >= 60 && UserJupiter <= 90)
            {
                JupiterZod = "Gemini";
            }
            else if (UserJupiter >= 90 && UserJupiter <= 120)
            {
                JupiterZod = "Cancer";
            }
            else if (UserJupiter >= 120 && UserJupiter <= 150)
            {
                JupiterZod = "Leo";
            }
            else if (UserJupiter >= 150 && UserJupiter <= 180)
            {
                JupiterZod = "Virgo";
            }
            else if (UserJupiter >= 180 && UserJupiter <= 210)
            {
                JupiterZod = "Libra";
            }
            else if (UserJupiter >= 210 && UserJupiter <= 240)
            {
                JupiterZod = "Scorpio";
            }
            else if (UserJupiter >= 240 && UserJupiter <= 270)
            {
                JupiterZod = "Sagittarius";
            }
            else if (UserJupiter >= 270 && UserJupiter <= 300)
            {
                JupiterZod = "Capricorn";
            }
            else if (UserJupiter >= 300 && UserJupiter <= 330)
            {
                JupiterZod = "Aquarius";
            }
            else if (UserJupiter >= 330 && UserJupiter <= 360)
            {
                JupiterZod = "Pisces";
            }
        }



        //SATURN

        public void SetSaturnZod()
        {
            if (UserSaturn >= 0 && UserSaturn <= 30)
            {
                SaturnZod = "Aries";
            }
            else if (UserSaturn >= 30 && UserSaturn <= 60)
            {
                SaturnZod = "Taurus";
            }
            else if (UserSaturn >= 60 && UserSaturn <= 90)
            {
                SaturnZod = "Gemini";
            }
            else if (UserSaturn >= 90 && UserSaturn <= 120)
            {
                SaturnZod = "Cancer";
            }
            else if (UserSaturn >= 120 && UserSaturn <= 150)
            {
                SaturnZod = "Leo";
            }
            else if (UserSaturn >= 150 && UserSaturn <= 180)
            {
                SaturnZod = "Virgo";
            }
            else if (UserSaturn >= 180 && UserSaturn <= 210)
            {
                SaturnZod = "Libra";
            }
            else if (UserSaturn >= 210 && UserSaturn <= 240)
            {
                SaturnZod = "Scorpio";
            }
            else if (UserSaturn >= 240 && UserSaturn <= 270)
            {
                SaturnZod = "Sagittarius";
            }
            else if (UserSaturn >= 270 && UserSaturn <= 300)
            {
                SaturnZod = "Capricorn";
            }
            else if (UserSaturn >= 300 && UserSaturn <= 330)
            {
                SaturnZod = "Aquarius";
            }
            else if (UserSaturn >= 330 && UserSaturn <= 360)
            {
                SaturnZod = "Pisces";
            }
        }

        //URANUS

        public void SetUranusZod()
        {
            if (UserUranus >= 0 && UserUranus <= 30)
            {
                UranusZod = "Aries";
            }
            else if (UserUranus >= 30 && UserUranus <= 60)
            {
                UranusZod = "Taurus";
            }
            else if (UserUranus >= 60 && UserUranus <= 90)
            {
                UranusZod = "Gemini";
            }
            else if (UserUranus >= 90 && UserUranus <= 120)
            {
                UranusZod = "Cancer";
            }
            else if (UserUranus >= 120 && UserUranus <= 150)
            {
                UranusZod = "Leo";
            }
            else if (UserUranus >= 150 && UserUranus <= 180)
            {
                UranusZod = "Virgo";
            }
            else if (UserUranus >= 180 && UserUranus <= 210)
            {
                UranusZod = "Libra";
            }
            else if (UserUranus >= 210 && UserUranus <= 240)
            {
                UranusZod = "Scorpio";
            }
            else if (UserUranus >= 240 && UserUranus <= 270)
            {
                UranusZod = "Sagittarius";
            }
            else if (UserUranus >= 270 && UserUranus <= 300)
            {
                UranusZod = "Capricorn";
            }
            else if (UserUranus >= 300 && UserUranus <= 330)
            {
                UranusZod = "Aquarius";
            }
            else if (UserUranus >= 330 && UserUranus <= 360)
            {
                UranusZod = "Pisces";
            }
        }

        //NEPTUNE

        public void SetNeptuneZod()
        {
            if (UserNeptune >= 0 && UserNeptune <= 30)
            {
                NeptuneZod = "Aries";
            }
            else if (UserNeptune >= 30 && UserNeptune <= 60)
            {
                NeptuneZod = "Taurus";
            }
            else if (UserNeptune >= 60 && UserNeptune <= 90)
            {
                NeptuneZod = "Gemini";
            }
            else if (UserNeptune >= 90 && UserNeptune <= 120)
            {
                NeptuneZod = "Cancer";
            }
            else if (UserNeptune >= 120 && UserNeptune <= 150)
            {
                NeptuneZod = "Leo";
            }
            else if (UserNeptune >= 150 && UserNeptune <= 180)
            {
                NeptuneZod = "Virgo";
            }
            else if (UserNeptune >= 180 && UserNeptune <= 210)
            {
                NeptuneZod = "Libra";
            }
            else if (UserNeptune >= 210 && UserNeptune <= 240)
            {
                NeptuneZod = "Scorpio";
            }
            else if (UserNeptune >= 240 && UserNeptune <= 270)
            {
                NeptuneZod = "Sagittarius";
            }
            else if (UserNeptune >= 270 && UserNeptune <= 300)
            {
                NeptuneZod = "Capricorn";
            }
            else if (UserNeptune >= 300 && UserNeptune <= 330)
            {
                NeptuneZod = "Aquarius";
            }
            else if (UserNeptune >= 330 && UserNeptune <= 360)
            {
                NeptuneZod = "Pisces";
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

        public void SetMercData()
        {
            Ecliptic mercquator = Mercury.EclipticalCoordinate(BirthDate);
            UserMerc = mercquator.Longitude;
        }

        public void SetVenusData()
        {
            Ecliptic vequator = Venus.EclipticalCoordinate(BirthDate);
            UserVenus = vequator.Longitude;
        }


        public void SetMarsData()
        {
            Ecliptic marsquator = Mars.EclipticalCoordinate(BirthDate);
            UserMars = marsquator.Longitude;
        }

        public void SetJupiterData()
        {
            Ecliptic jupquator = Jupiter.EclipticalCoordinate(BirthDate);
            UserJupiter = jupquator.Longitude;
        }

        public void SetSaturnData()
        {
            Ecliptic satquator = Saturn.EclipticalCoordinate(BirthDate);
            UserSaturn = satquator.Longitude;
        }


        public void SetUranusData()
        {
            Ecliptic urquator = Uranus.EclipticalCoordinate(BirthDate);
            UserUranus = urquator.Longitude;
        }

        public void SetNeptuneData()
        {
            Ecliptic nepquator = Neptune.EclipticalCoordinate(BirthDate);
            UserNeptune = nepquator.Longitude;
        }




    }
}