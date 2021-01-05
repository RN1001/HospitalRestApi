using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public Task<Patient> CreateAsync(Patient t)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Patient>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> FindByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> UpdateAsync(int? id, Patient t)
        {
            throw new NotImplementedException();
        }
    }
}
