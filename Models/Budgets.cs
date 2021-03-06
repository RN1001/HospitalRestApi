using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Models
{
    public class Budgets : BaseEntity
    {
        public double EquipmentBudget { get; set; }
        public double StaffingBudget { get; set; }
        public double TransportBudget { get; set; }
        public double DepartmentBudget { get; set; }
        public double TrainingBudget { get; set; }
        public DateTime BudgetAddedDateTime { get; set; }

    }
}
