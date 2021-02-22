using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Services
{
    public interface IDoctorService
    {
        public Task<Doctor> FindDoctorById(int? id);
        public Task<List<Doctor>> FindAllDoctors();
        public Task<Doctor> CreateDoctor(Doctor doctor);
        public Task<Doctor> UpdateDoctor(int? id, Doctor doctor);
        public Task<Doctor> DeleteDoctor(int? id);
    }
}
