using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiUdemy.Migrations
{
    public partial class AddBooksWithAuthorsAndRemoveAuthorFromBookTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "LibBook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "LibBook",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
