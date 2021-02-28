using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Repositories
{
    public class NurseRepository : EfRepository<Nurse>, INurseRepository
    {
        private readonly HospitalApiContext _context;

        public NurseRepository(HospitalApiContext context) : base(context)
        {
            this._context = context;
        }
    }
}
