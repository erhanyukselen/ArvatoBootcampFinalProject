using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblMovie",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    adult = table.Column<string>(type: "text", nullable: false),
                    belongs_to_collection = table.Column<string>(type: "text", nullable: true),
                    budget = table.Column<string>(type: "text", nullable: false),
                    genres = table.Column<string>(type: "text", nullable: false),
                    homepage = table.Column<string>(type: "text", nullable: true),
                    imdb_id = table.Column<string>(type: "text", nullable: true),
                    original_language = table.Column<string>(type: "text", nullable: true),
                    original_title = table.Column<string>(type: "text", nullable: false),
                    overview = table.Column<string>(type: "text", nullable: true),
                    popularity = table.Column<string>(type: "text", nullable: true),
                    poster_path = table.Column<string>(type: "text", nullable: true),
                    production_companies = table.Column<string>(type: "text", nullable: true),
                    production_countries = table.Column<string>(type: "text", nullable: true),
                    release_date = table.Column<string>(type: "text", nullable: true),
                    revenue = table.Column<int>(type: "integer", nullable: true),
                    runtime = table.Column<decimal>(type: "numeric", nullable: true),
                    spoken_languages = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    tagline = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    video = table.Column<string>(type: "text", nullable: true),
                    vote_average = table.Column<decimal>(type: "numeric", nullable: true),
                    vote_count = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMovie", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMovie");
        }
    }
}
