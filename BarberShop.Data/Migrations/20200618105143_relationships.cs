using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Data.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prices",
                table: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hairs",
                table: "Hairs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HairStylePrices",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Hairs");

            migrationBuilder.AddColumn<int>(
                name: "PricesId",
                table: "Prices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HairPrices",
                table: "Prices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HairStyleId",
                table: "Hairs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prices",
                table: "Prices",
                column: "PricesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hairs",
                table: "Hairs",
                column: "HairStyleId");

            migrationBuilder.CreateTable(
                name: "HairStylePrices",
                columns: table => new
                {
                    HairStyleId = table.Column<int>(nullable: false),
                    PricesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairStylePrices", x => new { x.HairStyleId, x.PricesId });
                    table.ForeignKey(
                        name: "FK_HairStylePrices_Hairs_HairStyleId",
                        column: x => x.HairStyleId,
                        principalTable: "Hairs",
                        principalColumn: "HairStyleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HairStylePrices_Prices_PricesId",
                        column: x => x.PricesId,
                        principalTable: "Prices",
                        principalColumn: "PricesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HairStylePrices_PricesId",
                table: "HairStylePrices",
                column: "PricesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HairStylePrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prices",
                table: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hairs",
                table: "Hairs");

            migrationBuilder.DropColumn(
                name: "PricesId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HairPrices",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "HairStyleId",
                table: "Hairs");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HairStylePrices",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Hairs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prices",
                table: "Prices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hairs",
                table: "Hairs",
                column: "Id");
        }
    }
}
