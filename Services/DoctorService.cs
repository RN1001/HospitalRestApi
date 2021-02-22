using HospitalRestApi.Models;
using HospitalRestApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public async Task<Doctor> CreateDoctor(Doctor doctor)
        {
            return await this.doctorRepository.CreateAsync(doctor);
        }

        public async Task<Doctor> DeleteDoctor(int? id)
        {
            return await this.doctorRepository.DeleteAsync(id);
        }

        public async Task<List<Doctor>> FindAllDoctors()
        {
            return await this.doctorRepository.FindAllAsync();
        }

        public async Task<Doctor> FindDoctorById(int? id)
        {
            return await this.doctorRepository.FindByIdAsync(id);
        }

        public async Task<Doctor> UpdateDoctor(int? id, Doctor doctor)
        {
            return await this.doctorRepository.UpdateAsync(id, doctor);
        }
    }
}
