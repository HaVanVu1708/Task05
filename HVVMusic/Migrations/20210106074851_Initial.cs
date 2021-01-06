using Microsoft.EntityFrameworkCore.Migrations;

namespace HVVMusic.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    MusicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<string>(nullable: true),
                    Likes = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.MusicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}
