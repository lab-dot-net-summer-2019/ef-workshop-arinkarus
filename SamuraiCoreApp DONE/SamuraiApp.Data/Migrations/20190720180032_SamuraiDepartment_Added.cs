using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Data.Migrations
{
    public partial class SamuraiDepartment_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SamuraiDepartmentId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SamuraiDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiDepartments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SamuraiDepartmentId",
                table: "Samurais",
                column: "SamuraiDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SamuraiDepartments_SamuraiDepartmentId",
                table: "Samurais",
                column: "SamuraiDepartmentId",
                principalTable: "SamuraiDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SamuraiDepartments_SamuraiDepartmentId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SamuraiDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SamuraiDepartmentId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SamuraiDepartmentId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Samurais");
        }
    }
}
