using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MaritalStatus
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
    }
}