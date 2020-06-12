using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_13.Migrations
{
    public partial class MadeOrderEmployeeIdNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Orders",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "IdEmployee",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Orders",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEmployee",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
