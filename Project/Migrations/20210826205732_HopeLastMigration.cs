using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class HopeLastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Reservations_ReservationId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ReservationId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Associations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100) CHARACTER SET utf8mb4",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "Pictures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Pictures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PictureId",
                table: "Associations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_PictureId",
                table: "Associations",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Pictures_PictureId",
                table: "Associations",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Pictures_PictureId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_PictureId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Associations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pictures",
                type: "varchar(100) CHARACTER SET utf8mb4",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "Pictures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Pictures",
                type: "varchar(255) CHARACTER SET utf8mb4",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Pictures",
                type: "varchar(100) CHARACTER SET utf8mb4",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Associations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ReservationId",
                table: "Associations",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Reservations_ReservationId",
                table: "Associations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
