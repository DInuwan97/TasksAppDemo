using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksApp.DataAccess.Migrations
{
    public partial class AuthorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Dinuwan Kalubowila" },
                    { 2, "Dureksha Wasala" },
                    { 3, "Chod Perera" },
                    { 4, "Chamika Visal" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 25, 15, 58, 54, 451, DateTimeKind.Local).AddTicks(8903), "Get books for school from DB", new DateTime(2021, 7, 30, 15, 58, 54, 453, DateTimeKind.Local).AddTicks(1173), 0, "Get Books" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 2, new DateTime(2021, 7, 25, 15, 58, 54, 453, DateTimeKind.Local).AddTicks(2315), "Get Medicine for sickness", new DateTime(2021, 7, 27, 15, 58, 54, 453, DateTimeKind.Local).AddTicks(2322), 1, "Get Medicine" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2021, 7, 25, 15, 58, 54, 453, DateTimeKind.Local).AddTicks(2331), "Get Foods from Resrurant", new DateTime(2021, 7, 28, 15, 58, 54, 453, DateTimeKind.Local).AddTicks(2332), 1, "Get Foods" });

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
