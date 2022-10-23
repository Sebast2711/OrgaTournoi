using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrgaTournoi.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipeJoueur_Equipe_equipesId",
                table: "EquipeJoueur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipeJoueur",
                table: "EquipeJoueur");

            migrationBuilder.DropIndex(
                name: "IX_EquipeJoueur_equipesId",
                table: "EquipeJoueur");

            migrationBuilder.RenameColumn(
                name: "equipesId",
                table: "EquipeJoueur",
                newName: "EquipesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipeJoueur",
                table: "EquipeJoueur",
                columns: new[] { "EquipesId", "JoueursId" });

            migrationBuilder.CreateIndex(
                name: "IX_EquipeJoueur_JoueursId",
                table: "EquipeJoueur",
                column: "JoueursId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipeJoueur_Equipe_EquipesId",
                table: "EquipeJoueur",
                column: "EquipesId",
                principalTable: "Equipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipeJoueur_Equipe_EquipesId",
                table: "EquipeJoueur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipeJoueur",
                table: "EquipeJoueur");

            migrationBuilder.DropIndex(
                name: "IX_EquipeJoueur_JoueursId",
                table: "EquipeJoueur");

            migrationBuilder.RenameColumn(
                name: "EquipesId",
                table: "EquipeJoueur",
                newName: "equipesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipeJoueur",
                table: "EquipeJoueur",
                columns: new[] { "JoueursId", "equipesId" });

            migrationBuilder.CreateIndex(
                name: "IX_EquipeJoueur_equipesId",
                table: "EquipeJoueur",
                column: "equipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipeJoueur_Equipe_equipesId",
                table: "EquipeJoueur",
                column: "equipesId",
                principalTable: "Equipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
