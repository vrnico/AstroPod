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
        public Content()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public string ContentId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
