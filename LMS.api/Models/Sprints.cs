using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class Sprints
    {
        [Key]
        public int Id { get; set; }


        public int BatchId { get; set; }

        [ForeignKey("BatchId")]
        public virtual Batches? Batches { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateOnly From_Day { get; set; }

        public DateOnly To_Day { get; set; }

        public int points { get; set; }

    }
}

