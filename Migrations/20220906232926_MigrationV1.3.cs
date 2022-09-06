using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisClubApi.Migrations
{
    public partial class MigrationV13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TennisCourtId",
                table: "CourtBooking",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CourtBooking_TennisCourtId",
                table: "CourtBooking",
                column: "TennisCourtId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourtBooking_TennisCourt_TennisCourtId",
                table: "CourtBooking",
                column: "TennisCourtId",
                principalTable: "TennisCourt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourtBooking_TennisCourt_TennisCourtId",
                table: "CourtBooking");

            migrationBuilder.DropIndex(
                name: "IX_CourtBooking_TennisCourtId",
                table: "CourtBooking");

            migrationBuilder.DropColumn(
                name: "TennisCourtId",
                table: "CourtBooking");
        }
    }
}
