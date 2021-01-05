using HospitalRestApi.Models;
using HospitalRestApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository PatientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            PatientRepository = patientRepository;
        }

        public async Task<Patient> CreatePatient(Patient patient)
        {
            return await this.PatientRepository.CreateAsync(patient);
        }

        public Task<Patient> DeletePatient(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Patient>> FindAllPatients()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> FindPatientById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> UpdatePatient(int? id, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
