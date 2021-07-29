using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksApp.DataAccess.Migrations
{
    public partial class todo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddresNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddresNo", "City", "FullName", "Street" },
                values: new object[,]
                {
                    { 1, "45", "Colombo 1", "Dinuwan Kalubowila", "Street 1" },
                    { 2, "35", "Colombo 2", "Dureksha Wasala", "Street 2" },
                    { 3, "25", "Colombo 3", "Chod Perera", "Street 3" },
                    { 4, "15", "Colombo 4", "Chamika Visal", "Street 4" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 28, 20, 1, 55, 196, DateTimeKind.Local).AddTicks(7786), "Get books for school from DB", new DateTime(2021, 8, 2, 20, 1, 55, 197, DateTimeKind.Local).AddTicks(9619), 0, "Get Books" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 2, new DateTime(2021, 7, 28, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1281), "Get Medicine for sickness", new DateTime(2021, 7, 30, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1288), 1, "Get Medicine" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2021, 7, 28, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1297), "Get Foods from Resrurant", new DateTime(2021, 7, 31, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1298), 1, "Get Foods" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
