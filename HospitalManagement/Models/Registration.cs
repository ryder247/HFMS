using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string LastName { get; set; }
        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string OtherName { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string FacultyNumber { get; set; }
        [StringLength(250)]
        public string FacultyName { get; set; }
        public int Age { get; set; }
        [Required]
        public DateTime RegistrationDateTime { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public int MaritalStatusId { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [StringLength(250)]
        public string Occupation { get; set; }
        public Religion Religion { get; set; }
        public int ReligionId { get; set; }
        [StringLength(250)]
        public string HomeAddress { get; set; }
        [StringLength(250)]
        public string PostalAddress { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Telephone { get; set; }
        [Required]
        [StringLength(250)]
        public string RelativeName { get; set; }
        [Required]
        [StringLength(100)]
        public string RelativePhone { get; set; }
        [StringLength(250)]
        public string RelativeAddress { get; set; }
        [StringLength(250)]
        public string District { get; set; }
        [StringLength(250)]
        public string SubDistrict { get; set; }
        [StringLength(250)]
        public string HealthInsuranceScheme { get; set; }
        [Required]
        public string HealthInsuranceSchemeId { get; set; }
    }
}