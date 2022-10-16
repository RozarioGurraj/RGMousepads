using Microsoft.EntityFrameworkCore.Migrations;

namespace RGMousepads.Migrations
{
    public partial class InitailCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MousepadsClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    shape = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<int>(nullable: false),
                    Review = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MousepadsClass", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MousepadsClass");
        }
    }
}
