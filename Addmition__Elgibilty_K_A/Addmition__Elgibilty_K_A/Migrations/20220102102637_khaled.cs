using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Addmition__Elgibilty_K_A.Migrations
{
    public partial class khaled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nick_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "statues_of_admission_elgibilty",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_Of_admission_elgibilty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    begaining_date_of_the_process = table.Column<DateTime>(type: "datetime2", nullable: false),
                    semesterNo = table.Column<int>(type: "int", nullable: false),
                    semesterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statues_of_admission_elgibilty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    high_school_certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Father_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mother_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nick_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Marital_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Civil_Registriation_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Civil_Registrition_No = table.Column<int>(type: "int", nullable: false),
                    Blood_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passport_No = table.Column<int>(type: "int", nullable: false),
                    Identity_No = table.Column<int>(type: "int", nullable: false),
                    Full_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Current_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Phone = table.Column<int>(type: "int", nullable: false),
                    Home_s_Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_of_certificate",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_of_certificate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acceptaple_configuration",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accept = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Acceptable_wishes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acceptaple_configuration", x => x.id);
                    table.ForeignKey(
                        name: "FK_Acceptaple_configuration_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admission_eligibility_request",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    The_Rate = table.Column<int>(type: "int", nullable: false),
                    city_of_high_school_cirtificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_high_school_cirtificate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    type_of_cirtificate_sy_or_forighn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_of_crtificat_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    front_image_of_identity_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    back_image_of_identity_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    check_recipt_image_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admission_eligibility_request", x => x.id);
                    table.ForeignKey(
                        name: "FK_admission_eligibility_request_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statues_of_student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_of_Acshiving = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Checked_recipet = table.Column<bool>(type: "bit", nullable: false),
                    Checked_document = table.Column<bool>(type: "bit", nullable: false),
                    Accept = table.Column<bool>(type: "bit", nullable: false),
                    Student_InfoId = table.Column<int>(type: "int", nullable: true),
                    Employee_Infoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statues_of_student", x => x.id);
                    table.ForeignKey(
                        name: "FK_Statues_of_student_Employee_Employee_Infoid",
                        column: x => x.Employee_Infoid,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Statues_of_student_Student_Student_InfoId",
                        column: x => x.Student_InfoId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faculty_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type_of_certificateid = table.Column<int>(type: "int", nullable: true),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.id);
                    table.ForeignKey(
                        name: "FK_Faculty_Type_of_certificate_Type_of_certificateid",
                        column: x => x.Type_of_certificateid,
                        principalTable: "Type_of_certificate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "admission_ligibility_request_SY",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    LAnguge_of_the_addmintion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subscription_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admission_ligibility_request_SY", x => x.id);
                    table.ForeignKey(
                        name: "FK_admission_ligibility_request_SY_admission_eligibility_request_id",
                        column: x => x.id,
                        principalTable: "admission_eligibility_request",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "setting_of_specialties",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chair_count = table.Column<int>(type: "int", nullable: false),
                    Minemum_rate = table.Column<int>(type: "int", nullable: false),
                    facultyid = table.Column<int>(type: "int", nullable: true),
                    Stautues_of_admi_eligiid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setting_of_specialties", x => x.id);
                    table.ForeignKey(
                        name: "FK_setting_of_specialties_Faculty_facultyid",
                        column: x => x.facultyid,
                        principalTable: "Faculty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_setting_of_specialties_statues_of_admission_elgibilty_Stautues_of_admi_eligiid",
                        column: x => x.Stautues_of_admi_eligiid,
                        principalTable: "statues_of_admission_elgibilty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wishss",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wish_faculty1id = table.Column<int>(type: "int", nullable: true),
                    wish_faculty2id = table.Column<int>(type: "int", nullable: true),
                    wish_faculty3id = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishss", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wishss_Faculty_wish_faculty1id",
                        column: x => x.wish_faculty1id,
                        principalTable: "Faculty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishss_Faculty_wish_faculty2id",
                        column: x => x.wish_faculty2id,
                        principalTable: "Faculty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishss_Faculty_wish_faculty3id",
                        column: x => x.wish_faculty3id,
                        principalTable: "Faculty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishss_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acceptaple_configuration_StudentId",
                table: "Acceptaple_configuration",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_admission_eligibility_request_StudentId",
                table: "admission_eligibility_request",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_Type_of_certificateid",
                table: "Faculty",
                column: "Type_of_certificateid");

            migrationBuilder.CreateIndex(
                name: "IX_setting_of_specialties_facultyid",
                table: "setting_of_specialties",
                column: "facultyid");

            migrationBuilder.CreateIndex(
                name: "IX_setting_of_specialties_Stautues_of_admi_eligiid",
                table: "setting_of_specialties",
                column: "Stautues_of_admi_eligiid");

            migrationBuilder.CreateIndex(
                name: "IX_Statues_of_student_Employee_Infoid",
                table: "Statues_of_student",
                column: "Employee_Infoid");

            migrationBuilder.CreateIndex(
                name: "IX_Statues_of_student_Student_InfoId",
                table: "Statues_of_student",
                column: "Student_InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishss_StudentId",
                table: "Wishss",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wishss_wish_faculty1id",
                table: "Wishss",
                column: "wish_faculty1id");

            migrationBuilder.CreateIndex(
                name: "IX_Wishss_wish_faculty2id",
                table: "Wishss",
                column: "wish_faculty2id");

            migrationBuilder.CreateIndex(
                name: "IX_Wishss_wish_faculty3id",
                table: "Wishss",
                column: "wish_faculty3id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acceptaple_configuration");

            migrationBuilder.DropTable(
                name: "admission_ligibility_request_SY");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "setting_of_specialties");

            migrationBuilder.DropTable(
                name: "Statues_of_student");

            migrationBuilder.DropTable(
                name: "Wishss");

            migrationBuilder.DropTable(
                name: "admission_eligibility_request");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "statues_of_admission_elgibilty");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Type_of_certificate");
        }
    }
}
