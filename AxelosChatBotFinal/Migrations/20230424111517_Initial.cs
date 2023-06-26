using Microsoft.EntityFrameworkCore.Migrations;

namespace AxelosChatBotFinal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PDFFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDFFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeparatedTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 1050, nullable: false),
                    PDFFileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeparatedTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeparatedTexts_PDFFiles_PDFFileId",
                        column: x => x.PDFFileId,
                        principalTable: "PDFFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeparatedTexts_PDFFileId",
                table: "SeparatedTexts",
                column: "PDFFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeparatedTexts");

            migrationBuilder.DropTable(
                name: "PDFFiles");
        }
    }
}
