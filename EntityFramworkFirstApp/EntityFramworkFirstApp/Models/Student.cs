
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramworkFirstApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string StudentIdentificationNumber { get; set; }
        public int? StudentSectionId { get; set; }
        public Section StudentSection { get; set; }
        public int? SemesterId { get; set; }
        public Semester Semester { get; set; }
        [NotMapped]
        public string TemporarySomething { get; set; }

    }
}
