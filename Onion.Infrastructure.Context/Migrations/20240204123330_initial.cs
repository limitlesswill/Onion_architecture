using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onion.Infrastructure.Context.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "studentCourse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentid = table.Column<int>(type: "int", nullable: true),
                    courseid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourse", x => x.id);
                    table.ForeignKey(
                        name: "FK_studentCourse_course_courseid",
                        column: x => x.courseid,
                        principalTable: "course",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_studentCourse_student_studentid",
                        column: x => x.studentid,
                        principalTable: "student",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentCourse_courseid",
                table: "studentCourse",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourse_studentid",
                table: "studentCourse",
                column: "studentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentCourse");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
