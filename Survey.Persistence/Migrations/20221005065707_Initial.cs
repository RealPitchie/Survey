using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Survey.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    SurveyId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyItem_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SurveyItemOption",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    SurveyItemId = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_SurveyItem_SurveyId",
                table: "SurveyItem",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyItemOption_SurveyItemId",
                table: "SurveyItemOption",
                column: "SurveyItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyItemOption");

            migrationBuilder.DropTable(
                name: "SurveyItem");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
