using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksApp.DataAccess.Migrations
{
    public partial class jobrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 29, 17, 10, 50, 775, DateTimeKind.Local).AddTicks(2138), new DateTime(2021, 8, 3, 17, 10, 50, 776, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 29, 17, 10, 50, 776, DateTimeKind.Local).AddTicks(6276), new DateTime(2021, 7, 31, 17, 10, 50, 776, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 29, 17, 10, 50, 776, DateTimeKind.Local).AddTicks(6294), new DateTime(2021, 8, 1, 17, 10, 50, 776, DateTimeKind.Local).AddTicks(6296) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 28, 20, 1, 55, 196, DateTimeKind.Local).AddTicks(7786), new DateTime(2021, 8, 2, 20, 1, 55, 197, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 28, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1281), new DateTime(2021, 7, 30, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 28, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1297), new DateTime(2021, 7, 31, 20, 1, 55, 198, DateTimeKind.Local).AddTicks(1298) });
        }
    }
}
