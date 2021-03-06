using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRestApi.Controllers
{
    [EnableCors("origins")]
    [ApiController]
    [Route("api")]
    public class BudgetController : Controller
    {
        private readonly IBudgetService _budgetService;

        public BudgetController(IBudgetService budgetService)
        {
            this._budgetService = budgetService;
        }

        [HttpGet, Route("budgets")]
        public async Task<List<Budgets>> FindAllBudgets()
        {
            return await this._budgetService.FindAllBudgets();
        }

        [HttpGet, Route("budgets/{id}")]
        public async Task<Budgets> FindBudgetsById(int? id)
        {
            return await this._budgetService.FindBudgetById(id);
        }

        [HttpPost, Route("budgets")]
        public async Task<Budgets> CreateBudgets(Budgets budgets)
        {
            return await this._budgetService.CreateBudget(budgets);
        }

        [HttpPut, Route("budgets/{id}")]
        public async Task<Budgets> UpdateBudgets(int? id, Budgets budgets)
        {
            return await this._budgetService.UpdateBudget(id, budgets);
        }

        [HttpDelete, Route("budgets/{id}")]
        public async Task<Budgets> DeleteBudgets(int? id)
        {
            return await this._budgetService.DeleteBudget(id);
        }
    }
}
