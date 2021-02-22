using HospitalRestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly HospitalApiContext context;

        public EfRepository(HospitalApiContext context)
        {
            this.context = context;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await this.context.AddAsync(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int? id)
        {
            var patientfound = await this.FindByIdAsync(id);

            if (patientfound == null)
            {
                return null;
            }

            this.context.Remove(patientfound);
            await this.context.SaveChangesAsync();
            return patientfound;
        }

        public async Task<List<T>> FindAllAsync()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> FindByIdAsync(int? id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(int? id, T entity)
        {
            if (id != entity.Id)
            {
                return null;
            }

            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return entity;
        }
    }
}
