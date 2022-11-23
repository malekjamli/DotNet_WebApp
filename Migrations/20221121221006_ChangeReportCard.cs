using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NETCoreIdentityCustom.Migrations
{
    public partial class ChangeReportCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ReportCard_ReportCardId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ReportCardId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ReportCardId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ReportCard",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ReportCard_ApplicationUserId",
                table: "ReportCard",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCard_AspNetUsers_ApplicationUserId",
                table: "ReportCard",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportCard_AspNetUsers_ApplicationUserId",
                table: "ReportCard");

            migrationBuilder.DropIndex(
                name: "IX_ReportCard_ApplicationUserId",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ReportCard");

            migrationBuilder.AddColumn<int>(
                name: "ReportCardId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
    }
}
