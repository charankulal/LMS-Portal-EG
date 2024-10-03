using System.ComponentModel.DataAnnotations;

namespace LMS.api.Models
{
    public class Batches
    {
        [Key]
        public int Id { get; set; }

        public int InstructorId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
