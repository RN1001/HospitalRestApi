using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Repositories
{
    public class BudgetsRepository : EfRepository<Budgets>, IBudgetRepository
    {
        private readonly HospitalApiContext _context;

        public BudgetsRepository(HospitalApiContext context) : base(context)
        {
            this._context = context;
        }
    }
}
