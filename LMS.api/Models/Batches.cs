using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class Batches
    {
        
        public int Id { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public virtual Users? Users { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Sprints>? Sprints { get; set; }
        public virtual ICollection<Attendances>? Attendance { get; set; }
        public virtual ICollection<BatchUsers>? BatchUsers { get; set; }

    }
}
