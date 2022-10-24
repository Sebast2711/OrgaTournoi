using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrgaTournoi.Migrations
{
    public partial class EvenementJeu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jeu_Jeu_JeuId",
                table: "Jeu");

            migrationBuilder.DropIndex(
                name: "IX_Jeu_JeuId",
                table: "Jeu");

            migrationBuilder.DropColumn(
                name: "JeuId",
                table: "Jeu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JeuId",
                table: "Jeu",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jeu_JeuId",
                table: "Jeu",
                column: "JeuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jeu_Jeu_JeuId",
                table: "Jeu",
                column: "JeuId",
                principalTable: "Jeu",
                principalColumn: "Id");
        }
    }
}
