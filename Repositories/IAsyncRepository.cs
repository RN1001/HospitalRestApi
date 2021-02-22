using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        public Task<T> FindByIdAsync(int? id);
        public Task<List<T>> FindAllAsync();
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(int? id, T entity);
        public Task<T> DeleteAsync(int? id);
    }
}
