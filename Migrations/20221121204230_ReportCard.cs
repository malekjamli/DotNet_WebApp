using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NETCoreIdentityCustom.Migrations
{
    public partial class ReportCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReportCardId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReportCard",
                columns: table => new
                {
                    ReportCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCard", x => x.ReportCardId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ReportCardId",
                table: "AspNetUsers",
                column: "ReportCardId",
                unique: true,
                filter: "[ReportCardId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ReportCard_ReportCardId",
                table: "AspNetUsers",
                column: "ReportCardId",
                principalTable: "ReportCard",
                principalColumn: "ReportCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ReportCard_ReportCardId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReportCard");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ReportCardId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ReportCardId",
                table: "AspNetUsers");
        }
    }
}
