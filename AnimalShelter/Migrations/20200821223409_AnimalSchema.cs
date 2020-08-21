using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class AnimalSchema : Migration
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
                    { 1, "1", "Iguana", "Yellow", "super sweet", "High", "Small dogs, children", 4f, "Perfect", "Lizard" },
                    { 2, "4", "Oceanic", "Black", "super sweet but bitey", "Medium", "Small dogs", 4f, "Perfect", "Octopus" },
                    { 3, "7", "Chinese", "speckled", "lays around", "Low", "Handler", 3f, "Perfect", "Red Panda" },
                    { 4, "1", "Canary", "Beige with Black muzzle", "super sweet", "Slothlike", "big dogs, friends", 4f, "Perfect", "Bird" },
                    { 5, "6 months", "Potbelly", "pink with black spots", "wants cuddles forever", "Bouncy", "Children", 4f, "Perfect", "Pig" },
                    { 6, "3", "African", "Yellow with spots", "rough and tumble", "Chill", "Small dogs, children", 4f, "Perfect", "Elephant" },
                    { 7, "1", "Rattle", "Grey/Silver", "bouncey and happy", "Medium", "Adults and random strangers", 4f, "Perfect", "Snake" },
                    { 8, "5", "Loch Ness", "pink and grey", "loves to climb", "Med-Low", "Small things", 3f, "Perfect", "Monster" },
                    { 9, "7", "Red", "white with brown spots, or is it brown with white spots", "can be nice when food is available", "Highest", "me", 4f, "Perfect", "Fox" },
                    { 10, "10", "Roo", "Yellow", "loyal and honest", "Normal", "Everyone", 2f, "Perfect", "Kangaroo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
