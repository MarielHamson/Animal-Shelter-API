using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnergyLevel = table.Column<string>(nullable: false),
                    GetsAlongWith = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Disposition = table.Column<string>(nullable: false),
                    Coloring = table.Column<string>(nullable: false),
                    NumOfFeet = table.Column<float>(nullable: false),
                    Size = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Coloring", "Disposition", "EnergyLevel", "GetsAlongWith", "NumOfFeet", "Size", "Type" },
                values: new object[,]
                {
                    { 1, "1", "Golden Retriever", "Yellow", "super sweet", "High", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 2, "1", "Golden Retriever", "Yellow", "super sweet", "Medium", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 3, "1", "Golden Retriever", "Yellow", "super sweet", "Low", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 4, "1", "Golden Retriever", "Yellow", "super sweet", "Slothlike", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 5, "1", "Golden Retriever", "Yellow", "super sweet", "Bouncy", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 6, "1", "Golden Retriever", "Yellow", "super sweet", "Chill", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 7, "1", "Golden Retriever", "Yellow", "super sweet", "Medium", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 8, "1", "Golden Retriever", "Yellow", "super sweet", "Med-Low", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 9, "1", "Golden Retriever", "Yellow", "super sweet", "Highest", "Small dogs, children", 4f, "Perfect", "Dog" },
                    { 10, "1", "Golden Retriever", "Yellow", "super sweet", "Normal", "Small dogs, children", 4f, "Perfect", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
