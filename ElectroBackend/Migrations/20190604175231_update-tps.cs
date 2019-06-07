using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectroBackend.Migrations
{
    public partial class updatetps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Counter_CounterId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "TransformerId",
                table: "Tps",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CounterId",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tps_TransformerId",
                table: "Tps",
                column: "TransformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Counter_CounterId",
                table: "Customers",
                column: "CounterId",
                principalTable: "Counter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tps_Transformers_TransformerId",
                table: "Tps",
                column: "TransformerId",
                principalTable: "Transformers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Counter_CounterId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tps_Transformers_TransformerId",
                table: "Tps");

            migrationBuilder.DropIndex(
                name: "IX_Tps_TransformerId",
                table: "Tps");

            migrationBuilder.DropColumn(
                name: "TransformerId",
                table: "Tps");

            migrationBuilder.AlterColumn<int>(
                name: "CounterId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Counter_CounterId",
                table: "Customers",
                column: "CounterId",
                principalTable: "Counter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
