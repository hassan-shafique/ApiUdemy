using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiUdemy.Migrations
{
    public partial class PublisherAddedWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "LibBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Publisher_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibBook_PublisherId",
                table: "LibBook",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibBook_Publisher_PublisherId",
                table: "LibBook",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibBook_Publisher_PublisherId",
                table: "LibBook");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_LibBook_PublisherId",
                table: "LibBook");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "LibBook");
        }
    }
}
