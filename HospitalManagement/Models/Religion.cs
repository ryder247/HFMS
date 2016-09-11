using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Religion
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}