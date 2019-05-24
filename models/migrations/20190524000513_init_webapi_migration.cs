using Microsoft.EntityFrameworkCore.Migrations;

namespace materi_docker.models.migrations
{
    public partial class init_webapi_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_bulan",
                columns: table => new
                {
                    m_bulan_id = table.Column<int>(nullable: false),
                    m_bulan_nama = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_bulan", x => x.m_bulan_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_bulan");
        }
    }
}
