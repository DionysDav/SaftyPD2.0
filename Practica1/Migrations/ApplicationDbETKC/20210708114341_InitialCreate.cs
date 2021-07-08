using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Practica1.Migrations.ApplicationDbETKC
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserIdent = table.Column<string>(type: "text", nullable: true),
                    PlanVisitDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PlanVisitTime = table.Column<string>(type: "text", nullable: true),
                    PersonCountInGroup = table.Column<int>(type: "integer", nullable: false),
                    IsConsentedForProcessingOfPD = table.Column<bool>(type: "boolean", nullable: false),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    TimeReques = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}
