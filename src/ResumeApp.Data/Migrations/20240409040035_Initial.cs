using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DegreeTypes",
                columns: table => new
                {
                    DegreeTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeTypes", x => x.DegreeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    ProgrammingLanguageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammingLanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.ProgrammingLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    TechnologyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.TechnologyId);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    UniversityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.UniversityId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetLineOne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetLineTwo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeId);
                    table.ForeignKey(
                        name: "FK_Resumes_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GraduationYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    UniversityId = table.Column<long>(type: "bigint", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DegreeTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ResumeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_DegreeTypes_DegreeTypeId",
                        column: x => x.DegreeTypeId,
                        principalTable: "DegreeTypes",
                        principalColumn: "DegreeTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Educations_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Educations_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "UniversityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    ResumeId = table.Column<long>(type: "bigint", nullable: false),
                    EmployerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Jobs_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobs_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeProgrammingLanguageAssociations",
                columns: table => new
                {
                    ResumeProgrammingLanguageAssociationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<long>(type: "bigint", nullable: false),
                    ProgrammingLanguageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeProgrammingLanguageAssociations", x => x.ResumeProgrammingLanguageAssociationId);
                    table.ForeignKey(
                        name: "FK_ResumeProgrammingLanguageAssociations_ProgrammingLanguages_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "ProgrammingLanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeProgrammingLanguageAssociations_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeServerAssociations",
                columns: table => new
                {
                    ResumeServerAssociationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<long>(type: "bigint", nullable: false),
                    ServerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeServerAssociations", x => x.ResumeServerAssociationId);
                    table.ForeignKey(
                        name: "FK_ResumeServerAssociations_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeServerAssociations_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeTechnologyAssociations",
                columns: table => new
                {
                    ResumeTechnologyAssociationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<long>(type: "bigint", nullable: false),
                    TechnologyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeTechnologyAssociations", x => x.ResumeTechnologyAssociationId);
                    table.ForeignKey(
                        name: "FK_ResumeTechnologyAssociations_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResumeTechnologyAssociations_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "TechnologyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobAchievements",
                columns: table => new
                {
                    JobAchievementId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobAchievementDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    JobId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAchievements", x => x.JobAchievementId);
                    table.ForeignKey(
                        name: "FK_JobAchievements_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_DegreeTypeId",
                table: "Educations",
                column: "DegreeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UniversityId",
                table: "Educations",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAchievements_JobId",
                table: "JobAchievements",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ResumeId",
                table: "Jobs",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_StateId",
                table: "Jobs",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_People_StateId",
                table: "People",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeProgrammingLanguageAssociations_ProgrammingLanguageId",
                table: "ResumeProgrammingLanguageAssociations",
                column: "ProgrammingLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeProgrammingLanguageAssociations_ResumeId",
                table: "ResumeProgrammingLanguageAssociations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_PersonId",
                table: "Resumes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeServerAssociations_ResumeId",
                table: "ResumeServerAssociations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeServerAssociations_ServerId",
                table: "ResumeServerAssociations",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeTechnologyAssociations_ResumeId",
                table: "ResumeTechnologyAssociations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeTechnologyAssociations_TechnologyId",
                table: "ResumeTechnologyAssociations",
                column: "TechnologyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "JobAchievements");

            migrationBuilder.DropTable(
                name: "ResumeProgrammingLanguageAssociations");

            migrationBuilder.DropTable(
                name: "ResumeServerAssociations");

            migrationBuilder.DropTable(
                name: "ResumeTechnologyAssociations");

            migrationBuilder.DropTable(
                name: "DegreeTypes");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
