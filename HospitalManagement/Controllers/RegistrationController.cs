using System;
using System.Linq;
using System.Web.Mvc;
using HospitalManagement.Models;
using HospitalManagement.ViewModel;

namespace HospitalManagement.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegistrationController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult PatientInfo()
        {
            var viewModel = new RegistrationViewModel
            {
                Genders = _context.Genders.ToList(),
                Religions = _context.Religions.ToList(),
                MaritalStatuses = _context.MaritalStatuses.ToList(),
                Title = "Add Patient Infomation"
            };

            return View(viewModel);
        }

        [Authorize]
        public ActionResult EditPatientInfo(int id)
        {
            var patientInfo = _context.Registrations.Single(r => r.Id.Equals(id));
            var viewModel = new RegistrationViewModel
            {
                Genders = _context.Genders.ToList(),
                Religions = _context.Religions.ToList(),
                MaritalStatuses = _context.MaritalStatuses.ToList(),
                FacultyNumber = patientInfo.FacultyNumber,
                RegistrationNumber = patientInfo.RegistrationNumber,
                FacultyName = patientInfo.FacultyName,
                LastName = patientInfo.LastName,
                FirstName = patientInfo.FirstName,
                OtherName = patientInfo.OtherName,
                DoB = patientInfo.DoB.ToString("d MMM yyyy"),
                Gender = patientInfo.GenderId,
                Religion = patientInfo.ReligionId,
                MaritalStatus = patientInfo.MaritalStatusId,
                Occupation = patientInfo.Occupation,
                PostalAddress = patientInfo.PostalAddress,
                Telephone = patientInfo.Telephone,
                RelativeName = patientInfo.RelativeName,
                RelativePhone = patientInfo.RelativePhone,
                District = patientInfo.District,
                HomeAddress = patientInfo.HomeAddress,
                Email = patientInfo.Email.ToLower(),
                RelativeAddress = patientInfo.RelativeAddress,
                SubDistrict = patientInfo.SubDistrict,
                HealthInsuranceScheme = patientInfo.HealthInsuranceScheme,
                HealthInsuranceSchemeId = patientInfo.HealthInsuranceSchemeId,
                Title = "Edit Patient Infomation"

            };

            return View("PatientInfo",viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PatientInfo(RegistrationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genders = _context.Genders.ToList();
                viewModel.Religions = _context.Religions.ToList();
                viewModel.MaritalStatuses = _context.MaritalStatuses.ToList();
                return View("PatientInfo", viewModel);
            }

            var registration = new Registration
            {
                FacultyNumber = viewModel.FacultyNumber,
                RegistrationNumber = viewModel.RegistrationNumber,
                FacultyName = viewModel.FacultyName,
                RegistrationDateTime = DateTime.Today,
                LastName = viewModel.LastName,
                FirstName = viewModel.FirstName,
                OtherName = viewModel.OtherName,
                DoB = DateTime.Parse(viewModel.DoB),
                Age = DateTime.Now.Year - DateTime.Parse(viewModel.DoB).Year,
                GenderId = viewModel.Gender,
                ReligionId = viewModel.Religion,
                MaritalStatusId = viewModel.MaritalStatus,
                Occupation = viewModel.Occupation,
                PostalAddress = viewModel.PostalAddress,
                Telephone = viewModel.Telephone,
                RelativeName = viewModel.RelativeName,
                RelativePhone = viewModel.RelativePhone,
                District = viewModel.District,
                HomeAddress = viewModel.HomeAddress,
                Email = viewModel.Email.ToLower(),
                RelativeAddress = viewModel.RelativeAddress,
                SubDistrict = viewModel.SubDistrict,
                HealthInsuranceScheme = viewModel.HealthInsuranceScheme,
                HealthInsuranceSchemeId = viewModel.HealthInsuranceSchemeId
            };

            _context.Registrations.Add(registration);
            _context.SaveChanges();

            return RedirectToAction("PatientInfo", "Registration");
        }
    }
}