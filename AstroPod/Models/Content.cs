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
            List<string[]> Placements = new List<string[]>();
            string[] planet = new string[] { "Sun" };
            string[] zod = new string[] { "Aries" };
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
