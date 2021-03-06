using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Repositories;

namespace HospitalRestApi.Services
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetRepository _budgetRepository;

        public BudgetService(IBudgetRepository budgetRepository)
        {
            this._budgetRepository = budgetRepository;
        }

        public async Task<Budgets> FindBudgetById(int? id)
        {
            return await _budgetRepository.FindByIdAsync(id);
        }

        public async Task<List<Budgets>> FindAllBudgets()
        {
            return await _budgetRepository.FindAllAsync();
        }

        public async Task<Budgets> CreateBudget(Budgets budget)
        {
            return await _budgetRepository.CreateAsync(budget);
        }

        public async Task<Budgets> UpdateBudget(int? id, Budgets budget)
        {
            return await _budgetRepository.UpdateAsync(id, budget);
        }

        public async Task<Budgets> DeleteBudget(int? id)
        {
            return await _budgetRepository.DeleteAsync(id);
        }
    }
}