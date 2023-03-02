using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reestr_oborudovanija.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_States_StateId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Statuses_StatusId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Storages_StorageId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_StateId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_StatusId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_StorageId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Equipments");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_State_id",
                table: "Equipments",
                column: "State_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Status_id",
                table: "Equipments",
                column: "Status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Storage_id",
                table: "Equipments",
                column: "Storage_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_States_State_id",
                table: "Equipments",
                column: "State_id",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Statuses_Status_id",
                table: "Equipments",
                column: "Status_id",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Storages_Storage_id",
                table: "Equipments",
                column: "Storage_id",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_States_State_id",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Statuses_Status_id",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Storages_Storage_id",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_State_id",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_Status_id",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_Storage_id",
                table: "Equipments");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "Equipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_StateId",
                table: "Equipments",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_StatusId",
                table: "Equipments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_StorageId",
                table: "Equipments",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_States_StateId",
                table: "Equipments",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Statuses_StatusId",
                table: "Equipments",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Storages_StorageId",
                table: "Equipments",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
