using System.ComponentModel.DataAnnotations;

namespace LMS.api.Models
{
    public class Contents
    {
        [Key]
        public int Id { get; set; }

        public int Content_Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool completion_status { get; set; }
    }
}
