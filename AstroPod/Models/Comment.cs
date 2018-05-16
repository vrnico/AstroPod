using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstroPod.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Author { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Comment Body")]
        public string TextBody { get; set; }
        public DateTime PostDate { get; set; }
        public string SunZodId { get; set; }
        public string ContentId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Content Content { get; set; }
    }
}