using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.api.Models
{
    public class UserCertifications
    {
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users? Users { get; set; }

       
        public int CertificateId { get; set; }

        [ForeignKey("CertificateId")]
        public virtual Certificates? Certificates { get; set; }
    }
}
