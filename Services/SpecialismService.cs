using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Repositories;

namespace HospitalRestApi.Services
{
    public class SpecialismService : ISpecialismService
    {

        private readonly ISpecialismRepository _specialismRepository;

        public SpecialismService(ISpecialismRepository specialismRepository)
        {
            this._specialismRepository = specialismRepository;
        }

        public async Task<Specialism> FindSpecialismById(int? id)
        {
            return await _specialismRepository.FindByIdAsync(id);
        }

        public async Task<List<Specialism>> FindAllSpecialisms()
        {
            return await _specialismRepository.FindAllAsync();
        }

        public async Task<Specialism> CreateSpecialism(Specialism specialism)
        {
            return await _specialismRepository.CreateAsync(specialism);
        }

        public async Task<Specialism> UpdateSpecialism(int? id, Specialism specialism)
        {
            return await _specialismRepository.UpdateAsync(id, specialism);
        }

        public async Task<Specialism> DeleteSpecialism(int? id)
        {
            return await _specialismRepository.DeleteAsync(id);
        }
    }
}
