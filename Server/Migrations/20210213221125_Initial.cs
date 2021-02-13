using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuarioWebCRUD.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfessionsInfo",
                columns: table => new
                {
                    ProfessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionsInfo", x => x.ProfessionId);
                });

            migrationBuilder.CreateTable(
                name: "UsersInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInfo", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfessionsInfo",
                columns: table => new
                {
                    UserProfessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionsInfoProfessionId = table.Column<int>(type: "int", nullable: true),
                    UsersInfoUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfessionsInfo", x => x.UserProfessionId);
                    table.ForeignKey(
                        name: "FK_UserProfessionsInfo_ProfessionsInfo_ProfessionsInfoProfessionId",
                        column: x => x.ProfessionsInfoProfessionId,
                        principalTable: "ProfessionsInfo",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfessionsInfo_UsersInfo_UsersInfoUserId",
                        column: x => x.UsersInfoUserId,
                        principalTable: "UsersInfo",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfessionsInfo_ProfessionsInfoProfessionId",
                table: "UserProfessionsInfo",
                column: "ProfessionsInfoProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfessionsInfo_UsersInfoUserId",
                table: "UserProfessionsInfo",
                column: "UsersInfoUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfessionsInfo");

            migrationBuilder.DropTable(
                name: "ProfessionsInfo");

            migrationBuilder.DropTable(
                name: "UsersInfo");
        }
    }
}
