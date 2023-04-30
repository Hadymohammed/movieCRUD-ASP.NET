using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movieCRUD_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class editmodelattrnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MoiveId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "logoUrl",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "MoiveId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MoiveId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "logoUrl");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "MoiveId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MoiveId");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Producers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Cinemas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Actors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MoiveId",
                table: "Actors_Movies",
                column: "MoiveId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
