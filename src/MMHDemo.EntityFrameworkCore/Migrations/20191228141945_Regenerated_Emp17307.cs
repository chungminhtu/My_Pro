using Microsoft.EntityFrameworkCore.Migrations;

namespace MMHDemo.Migrations
{
    public partial class Regenerated_Emp17307 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emp1s_AppChatMessages_ChatMessageId",
                table: "emp1s");

            migrationBuilder.DropIndex(
                name: "IX_emp1s_ChatMessageId",
                table: "emp1s");

            migrationBuilder.DropColumn(
                name: "ChatMessageId",
                table: "emp1s");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChatMessageId",
                table: "emp1s",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_emp1s_ChatMessageId",
                table: "emp1s",
                column: "ChatMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_emp1s_AppChatMessages_ChatMessageId",
                table: "emp1s",
                column: "ChatMessageId",
                principalTable: "AppChatMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
