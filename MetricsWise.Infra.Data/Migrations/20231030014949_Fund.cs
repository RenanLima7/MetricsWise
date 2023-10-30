using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetricsWise.Infra.Data.Migrations
{
    public partial class Fund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ticker = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "Name", "Ticker" },
                values: new object[] { 1L, "Maxi Renda Fundo Invest Imobiliario FII", "MXRF11" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funds");
        }
    }
}
