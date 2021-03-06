using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalRestApi.Models;

namespace HospitalRestApi.Services
{
    public interface IBudgetService
    {
        public Task<Budgets> FindBudgetById(int? id);
        public Task<List<Budgets>> FindAllBudgets();
        public Task<Budgets> CreateBudget(Budgets budget);
        public Task<Budgets> UpdateBudget(int? id, Budgets budget);
        public Task<Budgets> DeleteBudget(int? id);
    }
}