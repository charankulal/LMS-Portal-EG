using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class UserContentTracks
    {
       
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users? Users { get; set; }

        
        public int ContentId { get; set; }

        [ForeignKey("ContentId")]
        public virtual Contents? Contents { get; set; }

        public bool IsCompleted { get; set; }

        
    }
}
