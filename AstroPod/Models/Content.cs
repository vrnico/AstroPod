using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AstroPod.Models
{
    [Table("Content")]
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string SunZodId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Comment Comments { get; set; }
    }
}
