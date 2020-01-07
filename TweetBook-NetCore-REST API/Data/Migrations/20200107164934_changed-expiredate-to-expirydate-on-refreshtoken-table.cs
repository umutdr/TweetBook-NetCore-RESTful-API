using Microsoft.EntityFrameworkCore.Migrations;

namespace TweetBook_NetCore_REST_API.Data.Migrations
{
    public partial class changedexpiredatetoexpirydateonrefreshtokentable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpireDate",
                table: "RefreshTokens",
                newName: "ExpiryDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "RefreshTokens",
                newName: "ExpireDate");
        }
    }
}
