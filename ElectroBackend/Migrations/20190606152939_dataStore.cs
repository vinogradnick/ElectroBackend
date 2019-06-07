using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectroBackend.Migrations
{
    public partial class dataStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Fiders_FiderId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Tps_TpId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_FiderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TpId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FiderId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TpId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CounterId",
                table: "Sections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CounterId",
                table: "Sections",
                column: "CounterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Counter_CounterId",
                table: "Sections",
                column: "CounterId",
                principalTable: "Counter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Counter_CounterId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_CounterId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CounterId",
                table: "Sections");

            migrationBuilder.AddColumn<int>(
                name: "FiderId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TpId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FiderId",
                table: "Customers",
                column: "FiderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TpId",
                table: "Customers",
                column: "TpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Fiders_FiderId",
                table: "Customers",
                column: "FiderId",
                principalTable: "Fiders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Tps_TpId",
                table: "Customers",
                column: "TpId",
                principalTable: "Tps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
