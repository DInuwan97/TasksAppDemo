using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksApp.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2021, 7, 25, 13, 42, 37, 710, DateTimeKind.Local).AddTicks(2062), "Get books for school", new DateTime(2021, 7, 30, 13, 42, 37, 711, DateTimeKind.Local).AddTicks(3892), 0, "Get Books" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
