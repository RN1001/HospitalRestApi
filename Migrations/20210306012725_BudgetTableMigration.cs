using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalRestApi.Migrations
{
    public partial class BudgetTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentBudget = table.Column<double>(type: "float", nullable: false),
                    StaffingBudget = table.Column<double>(type: "float", nullable: false),
                    TransportBudget = table.Column<double>(type: "float", nullable: false),
                    DepartmentBudget = table.Column<double>(type: "float", nullable: false),
                    TrainingBudget = table.Column<double>(type: "float", nullable: false),
                    BudgetAddedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
