using Microsoft.EntityFrameworkCore.Migrations;

namespace GrapgQI.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Roll = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Name", "Roll" },
                values: new object[] { 101, "abc", "1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Name", "Roll" },
                values: new object[] { 102, "def", "2" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Name", "Roll" },
                values: new object[] { 103, "ghi", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
