using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Services
{
    public interface ISpecialismService
    {
        public Task<Specialism> FindSpecialismById(int? id);
        public Task<List<Specialism>> FindAllSpecialisms();
        public Task<Specialism> CreateSpecialism(Specialism specialism);
        public Task<Specialism> UpdateSpecialism(int? id, Specialism specialism);
        public Task<Specialism> DeleteSpecialism(int? id);
    }
}
