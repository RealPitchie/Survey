using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surveyor.Persistence.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyItemOption");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "SurveyItem",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "SurveyItem",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options",
                table: "SurveyItem");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "SurveyItem",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "SurveyItemOption",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SurveyItemId = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyItemOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyItemOption_SurveyItem_SurveyItemId",
                        column: x => x.SurveyItemId,
                        principalTable: "SurveyItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyItemOption_SurveyItemId",
                table: "SurveyItemOption",
                column: "SurveyItemId");
        }
    }
}
