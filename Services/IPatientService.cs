using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Services
{
    public interface IPatientService
    {
        public Task<Patient> FindPatientById(int? id);
        public Task<List<Patient>> FindAllPatients();
        public Task<Patient> CreatePatient(Patient patient);
        public Task<Patient> UpdatePatient(int? id, Patient patient);
        public Task<Patient> DeletePatient(int? id);
    }
}
