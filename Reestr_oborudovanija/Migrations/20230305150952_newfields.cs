using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reestr_oborudovanija.Migrations
{
    public partial class newfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Equipments",
                newName: "NameInList");

            migrationBuilder.AddColumn<bool>(
                name: "Accounting",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "BalanceValue",
                table: "Equipments",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CountFact",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountInList",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Depreciation",
                table: "Equipments",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "InventoryNumber",
                table: "Equipments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "ResidualValue",
                table: "Equipments",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accounting",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "BalanceValue",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "CountFact",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "CountInList",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "Depreciation",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "InventoryNumber",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "ResidualValue",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "NameInList",
                table: "Equipments",
                newName: "Count");
        }
    }
}
