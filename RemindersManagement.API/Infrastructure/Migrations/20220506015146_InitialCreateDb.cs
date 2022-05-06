using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemindersManagement.API.Infrastructure.Migrations
{
    public partial class InitialCreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "reminders");

            migrationBuilder.CreateTable(
                name: "Reminders",
                schema: "reminders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("fc2036ed-72ea-495f-8833-8a9872ff1d97"), "Learning Microservices", 1 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("d569289a-f0b4-40bb-8721-9f34549c85f9"), "Writing Blog", 0 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("e0c1f691-bfa1-4d10-8a59-61282fe016d3"), "Presentation prepare", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminders",
                schema: "reminders");
        }
    }
}
