using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_13.Migrations
{
    public partial class AddedAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Confectionary",
                columns: table => new
                {
                    IdConfectionary = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    PricePerIte = table.Column<float>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectionary", x => x.IdConfectionary);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(maxLength: 50, nullable: false),
                    LName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(maxLength: 50, nullable: false),
                    LName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAccepted = table.Column<DateTime>(nullable: false),
                    DateFinished = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(maxLength: 255, nullable: false),
                    IdClient = table.Column<int>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Order_Customer_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Customer",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Employee_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employee",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Confectionary_Order",
                columns: table => new
                {
                    IdConfection = table.Column<int>(nullable: false),
                    IdOrder = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectionary_Order", x => new { x.IdConfection, x.IdOrder });
                    table.ForeignKey(
                        name: "FK_Confectionary_Order_Confectionary_IdConfection",
                        column: x => x.IdConfection,
                        principalTable: "Confectionary",
                        principalColumn: "IdConfectionary",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Confectionary_Order_Order_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Order",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Confectionary",
                columns: new[] { "IdConfectionary", "Name", "PricePerIte", "Type" },
                values: new object[,]
                {
                    { 1, "Chocolate", 100f, "food" },
                    { 2, "sweets", 200f, "food" },
                    { 3, "baklawa", 150f, "food" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "IdClient", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Ahmad", "Alaziz" },
                    { 2, "Taha", "Savas" },
                    { 3, "Artem", "Rymar" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "IdEmployee", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Aghiad", "Alaziz" },
                    { 2, "maximus", "Savas" },
                    { 3, "Luis", "Rymar" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 1, new DateTime(1999, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "sdfdsf" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 3, new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "sdfdsf" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmployee", "Notes" },
                values: new object[] { 2, new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "sdfdsf" });

            migrationBuilder.InsertData(
                table: "Confectionary_Order",
                columns: new[] { "IdConfection", "IdOrder", "Notes", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "", 2 },
                    { 2, 1, "", 4 },
                    { 3, 3, "", 50 },
                    { 2, 3, "", 70 },
                    { 3, 2, "", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Confectionary_Order_IdOrder",
                table: "Confectionary_Order",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdClient",
                table: "Order",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdEmployee",
                table: "Order",
                column: "IdEmployee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Confectionary_Order");

            migrationBuilder.DropTable(
                name: "Confectionary");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
