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
        private readonly IPatientRepository patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public async Task<Patient> CreatePatient(Patient patient)
        {
            return await this.patientRepository.CreateAsync(patient);
        }

        public async Task<Patient> DeletePatient(int? id)
        {
            return await this.patientRepository.DeleteAsync(id);
        }

        public async Task<List<Patient>> FindAllPatients()
        {
            return await this.patientRepository.FindAllAsync();
        }

        public async Task<Patient> FindPatientById(int? id)
        {
            return await this.patientRepository.FindByIdAsync(id);
        }

        public async Task<Patient> UpdatePatient(int? id, Patient patient)
        {
            return await this.patientRepository.UpdateAsync(id, patient);
        }
    }
}
