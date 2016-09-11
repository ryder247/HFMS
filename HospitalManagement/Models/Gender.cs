using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Sex { get; set; }
    }
}