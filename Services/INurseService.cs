using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Services
{
    public interface INurseService
    {
        public Task<Nurse> FindNurseById(int? id);
        public Task<List<Nurse>> FindAllNurses();
        public Task<Nurse> CreateNurse(Nurse nurse);
        public Task<Nurse> UpdateNurse(int? id, Nurse nurse);
        public Task<Nurse> DeleteNurse(int? id);
    }
}
