using System.ComponentModel.DataAnnotations;

namespace LMS.api.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // roles can be Instructor, Admin, Trainee
        public string Role { get; set; } = string.Empty;

        public int Points { get; set; }

        public virtual ICollection<Attendances>? Attendance { get; set; }
        public virtual ICollection<BatchUsers>? BatchUsers { get; set; }
        public virtual ICollection<UserCertifications>? UserCertification { get; set; }
        public virtual ICollection<UserContentTracks>? UserContentTrack { get; set; }
        public virtual ICollection<Batches>? Batches { get; set; }
    }
}
