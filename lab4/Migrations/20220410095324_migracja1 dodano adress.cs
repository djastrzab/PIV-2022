using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4.Migrations
{
    public partial class migracja1dodanoadress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Clients");
        }
    }
}
