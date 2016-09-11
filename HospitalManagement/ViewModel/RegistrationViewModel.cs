using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HospitalManagement.Models;

namespace HospitalManagement.ViewModel
{
    public class RegistrationViewModel
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
        [Required]
        public DateTime RegistrationDateTime { get; set; }
        public int Gender { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public int MaritalStatus { get; set; }
        public IEnumerable<MaritalStatus> MaritalStatuses { get; set; }
        [Required]
        public string DoB { get; set; }
        [StringLength(250)]
        public string Occupation { get; set; }
        public int Religion { get; set; }
        public IEnumerable<Religion> Religions { get; set; }
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
        public string Title { get; set; }

    }
}