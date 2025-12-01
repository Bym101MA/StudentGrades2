using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentGrades.Migrations
{
    public partial class UpdateForFullNameAndJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Teachers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Students");
        }
    }
}
