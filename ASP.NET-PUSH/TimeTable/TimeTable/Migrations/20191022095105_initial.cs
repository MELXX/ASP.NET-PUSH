using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTable.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Lecture",
                columns: table => new
                {
                    LectureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModuleID = table.Column<int>(nullable: false),
                    VenueID = table.Column<int>(nullable: false),
                    start_time = table.Column<string>(nullable: true),
                    end_time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecture", x => x.LectureID);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    LecturerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    CourseID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.LecturerID);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MarkType = table.Column<int>(nullable: true),
                    MarkValue = table.Column<double>(nullable: false),
                    AssessmentID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarkID);
                });

            migrationBuilder.CreateTable(
                name: "ModuleAssessments",
                columns: table => new
                {
                    ModuleAssessmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssessmentID = table.Column<int>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleAssessments", x => x.ModuleAssessmentID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    CourseID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VenueName = table.Column<string>(nullable: true),
                    VenueRoom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueID);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModuleName = table.Column<string>(nullable: true),
                    ModuleDescription = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleID);
                    table.ForeignKey(
                        name: "FK_Module_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    AssessmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssessmentName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AssessmentType = table.Column<int>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false),
                    PredicateWeight = table.Column<double>(nullable: true),
                    FinalWeight = table.Column<double>(nullable: true),
                    Mark = table.Column<double>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.AssessmentID);
                    table.ForeignKey(
                        name: "FK_Assessments_Module_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Module",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Title" },
                values: new object[,]
                {
                    { 201, "BSc. IT" },
                    { 202, "BIS" }
                });

            migrationBuilder.InsertData(
                table: "Lecture",
                columns: new[] { "LectureID", "ModuleID", "VenueID", "end_time", "start_time" },
                values: new object[,]
                {
                    { 14, 404, 303, "Friday,10:10", "Friday,08:10" },
                    { 13, 404, 303, "Monday,9:00", "Monday,08:10" },
                    { 12, 404, 303, "Tuesday,10:00", "Tuesday,08:10" },
                    { 11, 404, 303, "Monday,09:00", "Monday,08:10" },
                    { 10, 403, 302, "Wedesday,12:00", "Wednesday,11:10" },
                    { 9, 403, 303, "Tuesday,18:00", "Tuesday,17:10" },
                    { 8, 403, 301, "Monday,10:00", "Monday,09:10" },
                    { 6, 402, 302, "Tuesday,18:10", "Tuesday,15:10" },
                    { 5, 402, 301, "Monday,13:00", "Monday,12:10" },
                    { 4, 401, 302, "Wednesday,13:10", "Wednesday,13:10" },
                    { 3, 401, 301, "Tuesday,17:00", "Tuesday,15:10" },
                    { 2, 401, 302, "Monday,14:00", "Monday,13:10" },
                    { 1, 401, 302, "Thursday,14:00", "Thursday,13:10" },
                    { 7, 403, 303, "Friday,14:00", "Friday,13:10" }
                });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "LecturerID", "CourseID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 185473538, null, "Ruan", "van der Westuizen" },
                    { 776546879, null, "Khanya", "Kolo" },
                    { 148269367, null, "Lizette", "de Wet" },
                    { 987679543, null, "Franco", "van der Merwe" },
                    { 135792468, null, "Pieter", "Bligies" },
                    { 123456789, null, "Rouxanne", "Fouche" },
                    { 987654321, null, "Jaco", "Marais" }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "MarkID", "AssessmentID", "MarkType", "MarkValue", "StudentID" },
                values: new object[,]
                {
                    { 24, 503, 1, 96.0, 2016875761 },
                    { 25, 504, 1, 18.0, 2016875761 },
                    { 27, 506, 1, 41.0, 2016875761 },
                    { 28, 507, 1, 88.0, 2016875761 },
                    { 29, 508, 1, 30.0, 2016875761 },
                    { 30, 509, 1, 98.0, 2016875761 },
                    { 31, 510, 1, 55.0, 2016875761 },
                    { 32, 511, 1, 94.0, 2016875761 },
                    { 33, 512, 1, 47.0, 2016875761 },
                    { 34, 513, 1, 88.0, 2016875761 },
                    { 36, 515, 1, 92.0, 2016875761 },
                    { 37, 516, 1, 55.0, 2016875761 },
                    { 38, 517, 1, 41.0, 2016875761 },
                    { 39, 518, 1, 67.0, 2016875761 },
                    { 40, 519, 1, 84.0, 2016875761 },
                    { 41, 520, 1, 36.0, 2016875761 },
                    { 42, 521, 1, 96.0, 2016875761 },
                    { 23, 502, 1, 33.0, 2016875761 },
                    { 35, 514, 1, 39.0, 2016875761 },
                    { 22, 501, 1, 56.0, 2016875761 },
                    { 26, 505, 1, 56.0, 2016875761 },
                    { 20, 520, 1, 76.0, 2017876764 },
                    { 21, 521, 1, 66.0, 2017876764 },
                    { 1, 501, 1, 76.0, 2017876764 },
                    { 2, 502, 1, 63.0, 2017876764 },
                    { 3, 503, 1, 86.0, 2017876764 },
                    { 4, 504, 1, 48.0, 2017876764 },
                    { 5, 505, 1, 94.0, 2017876764 },
                    { 7, 507, 1, 68.0, 2017876764 },
                    { 8, 508, 1, 60.0, 2017876764 },
                    { 9, 509, 1, 69.0, 2017876764 },
                    { 10, 510, 1, 65.0, 2017876764 },
                    { 6, 506, 1, 61.0, 2017876764 },
                    { 12, 512, 1, 27.0, 2017876764 },
                    { 13, 513, 1, 48.0, 2017876764 },
                    { 14, 514, 1, 99.0, 2017876764 },
                    { 15, 515, 1, 62.0, 2017876764 },
                    { 16, 516, 1, 85.0, 2017876764 },
                    { 17, 517, 1, 61.0, 2017876764 },
                    { 18, 518, 1, 37.0, 2017876764 },
                    { 11, 511, 1, 64.0, 2017876764 },
                    { 19, 519, 1, 54.0, 2017876764 }
                });

            migrationBuilder.InsertData(
                table: "ModuleAssessments",
                columns: new[] { "ModuleAssessmentID", "AssessmentID", "ModuleID" },
                values: new object[,]
                {
                    { 14, 513, 402 },
                    { 15, 514, 402 },
                    { 16, 515, 402 },
                    { 17, 516, 404 },
                    { 21, 520, 404 },
                    { 19, 518, 404 },
                    { 20, 519, 404 },
                    { 22, 521, 404 },
                    { 13, 512, 402 },
                    { 18, 517, 404 },
                    { 12, 511, 402 },
                    { 6, 505, 403 },
                    { 10, 509, 401 },
                    { 9, 508, 401 },
                    { 8, 507, 401 },
                    { 7, 506, 401 },
                    { 5, 504, 403 },
                    { 4, 503, 403 },
                    { 3, 502, 403 },
                    { 2, 501, 403 },
                    { 1, 500, 403 },
                    { 11, 510, 401 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "CourseID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2017106778, "201", "Michael", "Schmidt" },
                    { 2017106766, "201", "Meluthi", "Magwenya" },
                    { 2016039762, "201", "Norman", "Gytis" },
                    { 2017876764, "201", "Alexander", "Carson" },
                    { 2016875761, "201", "Meredith", "Alonso" },
                    { 2018867690, "201", "Nino", "Anand" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "VenueID", "VenueName", "VenueRoom" },
                values: new object[,]
                {
                    { 304, "LANDBOU", "5" },
                    { 301, "FGG", "255" },
                    { 302, "FGG", "378" },
                    { 303, "HMS", "--" },
                    { 305, "EBW", "7" }
                });

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "ModuleID", "CourseID", "ModuleDescription", "ModuleName" },
                values: new object[,]
                {
                    { 401, 201, "Networking", "CSIS3744" },
                    { 402, 201, "Introduction to Software Engineering", "CSIS3724" },
                    { 403, 201, "Internet Programming", "CSIS3714" },
                    { 404, 201, "Introduction to Databases", "CSIS3734" }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "AssessmentID", "AssessmentName", "AssessmentType", "Description", "Duration", "EndTime", "FinalWeight", "Mark", "ModuleID", "PredicateWeight", "StartTime" },
                values: new object[,]
                {
                    { 506, "Semester Test 1", 1, " ", "1hr", new DateTime(2019, 9, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 60.0, 401, 30.0, new DateTime(2019, 9, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 519, "Assignment 1", 2, " ", "15 Days", new DateTime(2019, 10, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 50.0, 404, 20.0, new DateTime(2019, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 518, "Main Exam 1", 0, " ", "3hrs", new DateTime(2019, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 60.0, 100.0, 404, null, new DateTime(2019, 11, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 517, "Semester Test 2", 1, " ", "1Hr", new DateTime(2019, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 60.0, 404, 30.0, new DateTime(2019, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 516, "Semester Test 1", 1, " ", "1Hr", new DateTime(2019, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 50.0, 404, 30.0, new DateTime(2019, 8, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 505, "Assignment 2", 2, " ", "5 days", new DateTime(2019, 10, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 30.0, 403, 10.0, new DateTime(2019, 10, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 504, "Online Quiz 1", 3, " ", "5 days", new DateTime(2019, 10, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 30.0, 403, 10.0, new DateTime(2019, 10, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 503, "Assignment 1", 2, " ", "1 month", new DateTime(2019, 10, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 100.0, 403, 20.0, new DateTime(2019, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 502, "Main Exam 1", 0, " ", "3hrs", new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 100.0, 403, null, new DateTime(2019, 11, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 501, "Semester Test 2", 1, " ", "1Hr", new DateTime(2019, 10, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 50.0, 403, 30.0, new DateTime(2019, 10, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 500, "Semester Test 1", 1, " ", "1Hr", new DateTime(2019, 8, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 50.0, 403, 30.0, new DateTime(2019, 8, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 515, "Assignment 2", 2, " ", "23 Days", new DateTime(2019, 10, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 70.0, 402, 55.0, new DateTime(2019, 10, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 514, "Semester Test 2", 1, " ", "1hr", new DateTime(2019, 11, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 42.0, 402, 50.0, new DateTime(2019, 11, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 513, "Assignment 1", 1, " ", "7 Days", new DateTime(2019, 9, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 52.0, 402, 45.0, new DateTime(2019, 9, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 512, "Main Exam 1", 0, " ", "3hrs", new DateTime(2019, 11, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 100.0, 402, null, new DateTime(2019, 11, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 511, "Semester Test 1", 1, " ", "1hr", new DateTime(2019, 9, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), null, 50.0, 402, 35.0, new DateTime(2019, 9, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 510, "Assignment 2", 2, " ", "13 Days", new DateTime(2019, 10, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 100.0, 401, 20.0, new DateTime(2019, 10, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 509, "Semester Test 2", 1, " ", "1hr", new DateTime(2019, 11, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 60.0, 401, 30.0, new DateTime(2019, 11, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 508, "Assignment 1", 1, " ", "7 Days", new DateTime(2019, 9, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 20.0, 401, 20.0, new DateTime(2019, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 507, "Main Exam 1", 0, " ", "3hrs", new DateTime(2019, 11, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 100.0, 401, null, new DateTime(2019, 11, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 520, "Online Quiz 1", 3, " ", "7 days", new DateTime(2019, 9, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 40.0, 404, 10.0, new DateTime(2019, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 521, "Assignment 2", 2, " ", "5 days", new DateTime(2019, 10, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), null, 100.0, 404, 10.0, new DateTime(2019, 10, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ModuleID",
                table: "Assessments",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_Module_CourseID",
                table: "Module",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Lecture");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "ModuleAssessments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
