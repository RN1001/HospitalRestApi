using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Repositories;

namespace HospitalRestApi.Services
{
    public class NurseService : INurseService
    {
        private readonly INurseRepository _nurseRepository;

        public NurseService(INurseRepository nurseRepository)
        {
            this._nurseRepository = nurseRepository;
        }

        public async Task<Nurse> FindNurseById(int? id)
        {
            return await _nurseRepository.FindByIdAsync(id);
        }

        public async Task<List<Nurse>> FindAllNurses()
        {
            return await _nurseRepository.FindAllAsync();
        }

        public async Task<Nurse> CreateNurse(Nurse nurse)
        {
            return await _nurseRepository.CreateAsync(nurse);
        }

        public async Task<Nurse> UpdateNurse(int? id, Nurse nurse)
        {
            return await _nurseRepository.UpdateAsync(id, nurse);
        }

        public async Task<Nurse> DeleteNurse(int? id)
        {
            return await _nurseRepository.DeleteAsync(id);
        }
    }
}
