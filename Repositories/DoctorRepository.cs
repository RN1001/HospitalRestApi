using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class DoctorRepository : EfRepository<Doctor>, IDoctorRepository
    {
        private readonly HospitalApiContext context;

        public DoctorRepository(HospitalApiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
