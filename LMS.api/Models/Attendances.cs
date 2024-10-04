using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class Attendances
    {
        
        public int BatchId { get; set; }

        [ForeignKey("BatchId")]
        public virtual Batches? Batches { get; set; }
        

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users? Users { get; set; }   

        public int Date {  get; set; }

        public bool remarks { get; set; }

    }
}
