using HospitalRestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class PatientRepository : EfRepository<Patient>, IPatientRepository
    {
        public readonly HospitalApiContext context;

        public PatientRepository(HospitalApiContext context) : base(context)
        {
            this.context = context;
        }
    
    }
    
}
