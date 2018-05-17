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
        public double UserSun { get; set; }
        public string SunZod { get; set; }
        public int SunId { get; set; }
        public int MoonId { get; set; }
        public int MercId{ get; set;}
        public int VenusId{ get; set;}
        public int MarsId{ get; set;}
        public int JupiterId{ get; set;}
        public int SaturnId{ get; set;}
        public int UranusId { get; set;}
        public int NeptuneId{ get; set;}
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
            this.Comments = new HashSet<Comment>();

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
                SunId = 9;
                
          }
            else if (UserSun >= 60 && UserSun <= 90)
            {
                SunZod = "Gemini";
                SunId = 18;
     
          }
            else if (UserSun >= 90 && UserSun <= 120)
            {
                SunZod = "Cancer";
                SunId = 27;
          }
            else if (UserSun >= 120 && UserSun <= 150)
            {
                SunZod = "Leo";
                SunId = 36;
          }
            else if (UserSun >= 150 && UserSun <= 180)
            {
                SunZod = "Virgo";
                SunId = 45;
          }
            else if (UserSun >= 180 && UserSun <= 210)
            {
                SunZod = "Libra";
                SunId = 54;
          }
            else if (UserSun >= 210 && UserSun <= 240)
            {
                SunZod = "Scorpio";
                SunId = 63;
          }
            else if (UserSun >= 240 && UserSun <= 270)
            {
                SunZod = "Sagittarius";
                SunId = 72;
          }
            else if (UserSun >= 270 && UserSun <= 300)
            {
                SunZod = "Capricorn";
                SunId = 81;
          }
            else if (UserSun >= 300 && UserSun <= 330)
            {
                SunZod = "Aquarius";
                SunId = 90;
          }
            else if (UserSun >= 330 && UserSun <= 360)
            {
                SunZod = "Pisces";
                SunId = 99;
          }
        }
        
        //MOON

        public void SetMoonZod()
        {
            if (UserMoon >= 0 && UserMoon <= 30)
            {
                MoonZod = "Aries";
                MoonId = 1;
            }
            else if (UserMoon >= 30 && UserMoon <= 60)
            {
                MoonZod = "Taurus";
                MoonId = 10;
            }
            else if (UserMoon >= 60 && UserMoon <= 90)
            {
                MoonZod = "Gemini";
                MoonId = 19;
            }
            else if (UserMoon >= 90 && UserMoon <= 120)
            {
                MoonZod = "Cancer";
                MoonId = 28;
            }
            else if (UserMoon >= 120 && UserMoon <= 150)
            {
                MoonZod = "Leo";
                MoonId = 37;
            }
            else if (UserMoon >= 150 && UserMoon <= 180)
            {
                MoonZod = "Virgo";
                MoonId = 46;
            }
            else if (UserMoon >= 180 && UserMoon <= 210)
            {
                MoonZod = "Libra";
                MoonId = 55;
            }
            else if (UserMoon >= 210 && UserMoon <= 240)
            {
                MoonZod = "Scorpio";
                MoonId = 64;
            }
            else if (UserMoon >= 240 && UserMoon <= 270)
            {
                MoonZod = "Sagittarius";
                MoonId = 73;
            }
            else if (UserMoon >= 270 && UserMoon <= 300)
            {
                MoonZod = "Capricorn";
                MoonId = 82;
            }
            else if (UserMoon >= 300 && UserMoon <= 330)
            {
                MoonZod = "Aquarius";
                MoonId = 91;
            }
            else if (UserMoon >= 330 && UserMoon <= 360)
            {
                MoonZod = "Pisces";
                MoonId = 100;
            }
        }

        //MERCURY

        public void SetMercZod()
        {
            if (UserMerc >= 0 && UserMerc <= 30)
            {
                MercZod = "Aries";
                MercId = 2;
            }
            else if (UserMerc >= 30 && UserMerc <= 60)
            {
                MercZod = "Taurus";
                MercId = 11;
            }
            else if (UserMerc >= 60 && UserMerc <= 90)
            {
                MercZod = "Gemini";
                MercId = 20;
            }
            else if (UserMerc >= 90 && UserMerc <= 120)
            {
                MercZod = "Cancer";
                MercId = 29;
            }
            else if (UserMerc >= 120 && UserMerc <= 150)
            {
                MercZod = "Leo";
                MercId = 38;
            }
            else if (UserMerc >= 150 && UserMerc <= 180)
            {
                MercZod = "Virgo";
                MercId = 47;
            }
            else if (UserMerc >= 180 && UserMerc <= 210)
            {
                MercZod = "Libra";
                MercId = 56;
            }
            else if (UserMerc >= 210 && UserMerc <= 240)
            {
                MercZod = "Scorpio";
                MercId = 65;
            }
            else if (UserMerc >= 240 && UserMerc <= 270)
            {
                MercZod = "Sagittarius";
                MercId = 74;
            }
            else if (UserMerc >= 270 && UserMerc <= 300)
            {
                MercZod = "Capricorn";
                MercId = 83;
            }
            else if (UserMerc >= 300 && UserMerc <= 330)
            {
                MercZod = "Aquarius";
                MercId = 92;
                
            }
            else if (UserMerc >= 330 && UserMerc <= 360)
            {
                MercZod = "Pisces";
                MercId = 101;
            }
        }

        //VENUS

        public void SetVenusZod()
        {
            if (UserVenus >= 0 && UserVenus <= 30)
            {
                VenusZod = "Aries";
                VenusId = 3;
            }
            else if (UserVenus >= 30 && UserVenus <= 60)
            {
                VenusZod = "Taurus";
                VenusId = 12;
            }
            else if (UserVenus >= 60 && UserVenus <= 90)
            {
                VenusZod = "Gemini";
                VenusId = 21;
            }
            else if (UserVenus >= 90 && UserVenus <= 120)
            {
                VenusZod = "Cancer";
                VenusId = 30;
            }
            else if (UserVenus >= 120 && UserVenus <= 150)
            {
                VenusZod = "Leo";
                VenusId = 39;
            }
            else if (UserVenus >= 150 && UserVenus <= 180)
            {
                VenusZod = "Virgo";
                VenusId = 48;
            }
            else if (UserVenus >= 180 && UserVenus <= 210)
            {
                VenusZod = "Libra";
                VenusId = 57;
            }
            else if (UserVenus >= 210 && UserVenus <= 240)
            {
                VenusZod = "Scorpio";
                VenusId = 66;
            }
            else if (UserVenus >= 240 && UserVenus <= 270)
            {
                VenusZod = "Sagittarius";
                VenusId = 75;
            }
            else if (UserVenus >= 270 && UserVenus <= 300)
            {
                VenusZod = "Capricorn";
                VenusId = 84;
            }
            else if (UserVenus >= 300 && UserVenus <= 330)
            {
                VenusZod = "Aquarius";
                VenusId = 93;
            }
            else if (UserVenus >= 330 && UserVenus <= 360)
            {
                VenusZod = "Pisces";
                VenusId = 102;
            }
        }

        //MARS

        public void SetMarsZod()
        {
            if (UserMars >= 0 && UserMars <= 30)
            {
                MarsZod = "Aries";
                MarsId = 4;
            }
            else if (UserMars >= 30 && UserMars <= 60)
            {
                MarsZod = "Taurus";
                MarsId = 13;
            }
            else if (UserMars >= 60 && UserMars <= 90)
            {
                MarsZod = "Gemini";
                MarsId = 22;
            }
            else if (UserMars >= 90 && UserMars <= 120)
            {
                MarsZod = "Cancer";
                MarsId = 31;
            }
            else if (UserMars >= 120 && UserMars <= 150)
            {
                MarsZod = "Leo";
                MarsId = 40;
            }
            else if (UserMars >= 150 && UserMars <= 180)
            {
                MarsZod = "Virgo";
                MarsId = 49;
            }
            else if (UserMars >= 180 && UserMars <= 210)
            {
                MarsZod = "Libra";
                MarsId = 58;
            }
            else if (UserMars >= 210 && UserMars <= 240)
            {
                MarsZod = "Scorpio";
                MarsId = 67;
            }
            else if (UserMars >= 240 && UserMars <= 270)
            {
                MarsZod = "Sagittarius";
                MarsId = 76;
            }
            else if (UserMars >= 270 && UserMars <= 300)
            {
                MarsZod = "Capricorn";
                MarsId = 85;
            }
            else if (UserMars >= 300 && UserMars <= 330)
            {
                MarsZod = "Aquarius";
                MarsId = 94;
            }
            else if (UserMars >= 330 && UserMars <= 360)
            {
                MarsZod = "Pisces";
                MarsId = 103;
            }
        }

        //JUPITER

        public void SetJupiterZod()
        {
            if (UserJupiter >= 0 && UserJupiter <= 30)
            {
                JupiterZod = "Aries";
                JupiterId = 5;
            }
            else if (UserJupiter >= 30 && UserJupiter <= 60)
            {
                JupiterZod = "Taurus";
                JupiterId = 14;

            }
            else if (UserJupiter >= 60 && UserJupiter <= 90)
            {
                JupiterZod = "Gemini";
                JupiterId = 23;
            }
            else if (UserJupiter >= 90 && UserJupiter <= 120)
            {
                JupiterZod = "Cancer";
                JupiterId = 32;
            }
            else if (UserJupiter >= 120 && UserJupiter <= 150)
            {
                JupiterZod = "Leo";
                JupiterId = 41;
            }
            else if (UserJupiter >= 150 && UserJupiter <= 180)
            {
                JupiterZod = "Virgo";
                JupiterId = 50;
            }
            else if (UserJupiter >= 180 && UserJupiter <= 210)
            {
                JupiterZod = "Libra";
                JupiterId = 59;
            }
            else if (UserJupiter >= 210 && UserJupiter <= 240)
            {
                JupiterZod = "Scorpio";
                JupiterId = 68;
            }
            else if (UserJupiter >= 240 && UserJupiter <= 270)
            {
                JupiterZod = "Sagittarius";
                JupiterId = 77;
            }
            else if (UserJupiter >= 270 && UserJupiter <= 300)
            {
                JupiterZod = "Capricorn";
                JupiterId = 86;
            }
            else if (UserJupiter >= 300 && UserJupiter <= 330)
            {
                JupiterZod = "Aquarius";
                JupiterId = 95;
            }
            else if (UserJupiter >= 330 && UserJupiter <= 360)
            {
                JupiterZod = "Pisces";
                JupiterId = 104;
            }
        }



        //SATURN

        public void SetSaturnZod()
        {
            if (UserSaturn >= 0 && UserSaturn <= 30)
            {
                SaturnZod = "Aries";
                SaturnId = 6;
            }
            else if (UserSaturn >= 30 && UserSaturn <= 60)
            {
                SaturnZod = "Taurus";
                SaturnId = 15;
            }
            else if (UserSaturn >= 60 && UserSaturn <= 90)
            {
                SaturnZod = "Gemini";
                SaturnId = 24;
            }
            else if (UserSaturn >= 90 && UserSaturn <= 120)
            {
                SaturnZod = "Cancer";
                SaturnId = 33;
            }
            else if (UserSaturn >= 120 && UserSaturn <= 150)
            {
                SaturnZod = "Leo";
                SaturnId = 42;
            }
            else if (UserSaturn >= 150 && UserSaturn <= 180)
            {
                SaturnZod = "Virgo";
                SaturnId = 51;
            }
            else if (UserSaturn >= 180 && UserSaturn <= 210)
            {
                SaturnZod = "Libra";
                SaturnId = 60;
            }
            else if (UserSaturn >= 210 && UserSaturn <= 240)
            {
                SaturnZod = "Scorpio";
                SaturnId = 69;
            }
            else if (UserSaturn >= 240 && UserSaturn <= 270)
            {
                SaturnZod = "Sagittarius";
                SaturnId = 78;
            }
            else if (UserSaturn >= 270 && UserSaturn <= 300)
            {
                SaturnZod = "Capricorn";
                SaturnId = 87;
            }
            else if (UserSaturn >= 300 && UserSaturn <= 330)
            {
                SaturnZod = "Aquarius";
                SaturnId = 96;
            }
            else if (UserSaturn >= 330 && UserSaturn <= 360)
            {
                SaturnZod = "Pisces";
                SaturnId = 105;
            }
        }

        //URANUS

        public void SetUranusZod()
        {
            if (UserUranus >= 0 && UserUranus <= 30)
            {
                UranusZod = "Aries";
                UranusId = 7;
            }
            else if (UserUranus >= 30 && UserUranus <= 60)
            {
                UranusZod = "Taurus";
                UranusId = 16;
            }
            else if (UserUranus >= 60 && UserUranus <= 90)
            {
                UranusZod = "Gemini";
                UranusId = 25;
            }
            else if (UserUranus >= 90 && UserUranus <= 120)
            {
                UranusZod = "Cancer";
                UranusId = 34;
            }
            else if (UserUranus >= 120 && UserUranus <= 150)
            {
                UranusZod = "Leo";
                UranusId = 43;
            }
            else if (UserUranus >= 150 && UserUranus <= 180)
            {
                UranusZod = "Virgo";
                UranusId = 52;
            }
            else if (UserUranus >= 180 && UserUranus <= 210)
            {
                UranusZod = "Libra";
                UranusId = 61;
            }
            else if (UserUranus >= 210 && UserUranus <= 240)
            {
                UranusZod = "Scorpio";
                UranusId = 70;
            }
            else if (UserUranus >= 240 && UserUranus <= 270)
            {
                UranusZod = "Sagittarius";
                UranusId = 79;
            }
            else if (UserUranus >= 270 && UserUranus <= 300)
            {
                UranusZod = "Capricorn";
                UranusId = 88;
            }
            else if (UserUranus >= 300 && UserUranus <= 330)
            {
                UranusZod = "Aquarius";
                UranusId = 97;
            }
            else if (UserUranus >= 330 && UserUranus <= 360)
            {
                UranusZod = "Pisces";
                UranusId = 106;
            }
        }

        //NEPTUNE

        public void SetNeptuneZod()
        {
            if (UserNeptune >= 0 && UserNeptune <= 30)
            {
                NeptuneZod = "Aries";
                NeptuneId = 8;
            }
            else if (UserNeptune >= 30 && UserNeptune <= 60)
            {
                NeptuneZod = "Taurus";
                NeptuneId = 17;
            }
            else if (UserNeptune >= 60 && UserNeptune <= 90)
            {
                NeptuneZod = "Gemini";
                NeptuneId = 26;
            }
            else if (UserNeptune >= 90 && UserNeptune <= 120)
            {
                NeptuneZod = "Cancer";
                NeptuneId = 35;
            }
            else if (UserNeptune >= 120 && UserNeptune <= 150)
            {
                NeptuneZod = "Leo";
                NeptuneId = 44;
            }
            else if (UserNeptune >= 150 && UserNeptune <= 180)
            {
                NeptuneZod = "Virgo";
                NeptuneId = 53;
            }
            else if (UserNeptune >= 180 && UserNeptune <= 210)
            {
                NeptuneZod = "Libra";
                NeptuneId = 62;
            }
            else if (UserNeptune >= 210 && UserNeptune <= 240)
            {
                NeptuneZod = "Scorpio";
                NeptuneId = 71;
            }
            else if (UserNeptune >= 240 && UserNeptune <= 270)
            {
                NeptuneZod = "Sagittarius";
                NeptuneId = 80;
            }
            else if (UserNeptune >= 270 && UserNeptune <= 300)
            {
                NeptuneZod = "Capricorn";
                NeptuneId = 89;
            }
            else if (UserNeptune >= 300 && UserNeptune <= 330)
            {
                NeptuneZod = "Aquarius";
                NeptuneId = 98;
            }
            else if (UserNeptune >= 330 && UserNeptune <= 360)
            {
                NeptuneZod = "Pisces";
                NeptuneId = 107;
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