using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AstroPod.Migrations;

namespace AstroPod.Models
{
    [Table("Content")]
    public class Content
    {
  

       

        [Key]
        public string ContentId { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public static List<string[]> Placements { get; set; }

        public Content()
        {
            this.Comments = new HashSet<Comment>();


        }

        public static void SetList()
        {
            Placements = new List<string[]> { };
            string[] planet = new string[] { "Sun", "Moon", "Mercury", "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            string[] zod = new string[] { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
            foreach (string z in zod)
            {
                foreach (string p in planet)
                {
                    string[] combo = { z, p };

                    Placements.Add(combo);

                }
            }

        }

    }
}
