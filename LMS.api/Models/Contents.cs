using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class Contents
    {
        [Key]
        public int ContentId { get; set; }

        public int SprintId { get; set; }

        [ForeignKey("SprintId")]
        public virtual Sprints? Sprints { get; set; }

        
        

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public virtual ICollection<UserContentTracks>? UserContentTrack { get; set; }
    }
}
