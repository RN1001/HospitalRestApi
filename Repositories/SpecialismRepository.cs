using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Repositories
{
    public class SpecialismRepository : EfRepository<Specialism>, ISpecialismRepository
    {
        private readonly HospitalApiContext _context;
        public SpecialismRepository(HospitalApiContext context) : base(context)
        {
            this._context = context;
        }
    }
}
