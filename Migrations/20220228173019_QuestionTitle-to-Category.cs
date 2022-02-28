using Microsoft.EntityFrameworkCore.Migrations;

namespace sanoya_sandbox.Migrations
{
    public partial class QuestionTitletoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
