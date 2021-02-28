using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Repositories
{
    public interface INurseRepository : IAsyncRepository<Nurse>
    {
    }
}
