using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class CatsAndDogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnergyLevel = table.Column<string>(nullable: false),
                    GetsAlongWith = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Disposition = table.Column<string>(nullable: false),
                    Coloring = table.Column<string>(nullable: false),
                    NumOfFeet = table.Column<float>(nullable: false),
                    Size = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnergyLevel = table.Column<string>(nullable: false),
                    GetsAlongWith = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Disposition = table.Column<string>(nullable: false),
                    Coloring = table.Column<string>(nullable: false),
                    NumOfFeet = table.Column<float>(nullable: false),
                    Size = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Coloring", "Disposition", "EnergyLevel", "GetsAlongWith", "NumOfFeet", "Size" },
                values: new object[,]
                {
                    { 1, "1", "British Shorthair", "Yellow", "super sweet", "High", "Small dogs, children", 4f, "Perfect" },
                    { 9, "7", "Abyssinian", "white with brown spots, or is it brown with white spots", "can be nice when food is available", "Highest", "me", 4f, "Perfect" },
                    { 8, "5", "American Shorthair", "pink and grey", "loves to climb", "Med-Low", "Small things", 3f, "Perfect" },
                    { 7, "1", "Siamese", "Grey/Silver", "bouncey and happy", "Medium", "Adults and random strangers", 4f, "Perfect" },
                    { 6, "3", "Persian", "Yellow with spots", "rough and tumble", "Chill", "Small dogs, children", 4f, "Perfect" },
                    { 10, "10", "Russian Blue", "Yellow", "loyal and honest", "Normal", "Everyone", 2f, "Perfect" },
                    { 4, "1", "Sphynx", "Beige with Black muzzle", "super sweet", "Slothlike", "big dogs, friends", 4f, "Perfect" },
                    { 3, "7", "Rag doll", "speckled", "lays around", "Low", "Handler", 3f, "Perfect" },
                    { 2, "4", "Maine Coon", "Black", "super sweet but bitey", "Medium", "Small dogs", 4f, "Perfect" },
                    { 5, "6 months", "Bengal", "pink with black spots", "wants cuddles forever", "Bouncy", "Children", 4f, "Perfect" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Coloring", "Disposition", "EnergyLevel", "GetsAlongWith", "NumOfFeet", "Size" },
                values: new object[,]
                {
                    { 9, "7", "Rat Terrier", "white with brown spots, or is it brown with white spots", "can be nice when food is available", "Highest", "me", 4f, "Perfect" },
                    { 1, "1", "Golden Retriever", "Yellow", "super sweet", "High", "Small dogs, children", 4f, "Perfect" },
                    { 2, "4", "Labrador Retriever", "Black", "super sweet but bitey", "Medium", "Small dogs", 4f, "Perfect" },
                    { 3, "7", "French Bulldog", "speckled", "lays around", "Low", "Handler", 3f, "Perfect" },
                    { 4, "1", "Pug", "Beige with Black muzzle", "super sweet", "Slothlike", "big dogs, friends", 4f, "Perfect" },
                    { 5, "6 months", "Affenpinscher", "pink with black spots", "wants cuddles forever", "Bouncy", "Children", 4f, "Perfect" },
                    { 6, "3", "Poodle", "Yellow with spots", "rough and tumble", "Chill", "Small dogs, children", 4f, "Perfect" },
                    { 7, "1", "Weimeraner", "Grey/Silver", "bouncey and happy", "Medium", "Adults and random strangers", 4f, "Perfect" },
                    { 8, "5", "Chihuahua", "pink and grey", "loves to climb", "Med-Low", "Small things", 3f, "Perfect" },
                    { 10, "10", "Great Dane", "Yellow", "loyal and honest", "Normal", "Everyone", 2f, "Perfect" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Coloring = table.Column<string>(nullable: false),
                    Disposition = table.Column<string>(nullable: false),
                    EnergyLevel = table.Column<string>(nullable: false),
                    GetsAlongWith = table.Column<string>(nullable: false),
                    NumOfFeet = table.Column<float>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
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
                    { 2, "4", "Labrador Retriever", "Black", "super sweet but bitey", "Medium", "Small dogs", 4f, "Perfect", "Dog" },
                    { 3, "7", "Iguana", "speckled", "lays around", "Low", "Handler", 3f, "Perfect", "Lizard" },
                    { 4, "1", "Pug", "Beige with Black muzzle", "super sweet", "Slothlike", "big dogs, friends", 4f, "Perfect", "Dog" },
                    { 5, "6 months", "Potbelly", "pink with black spots", "wants cuddles forever", "Bouncy", "Children", 4f, "Perfect", "Pig" },
                    { 6, "3", "Leopard", "Yellow with spots", "rough and tumble", "Chill", "Small dogs, children", 4f, "Perfect", "Cat" },
                    { 7, "1", "Weimeraner", "Grey/Silver", "bouncey and happy", "Medium", "Adults and random strangers", 4f, "Perfect", "Dog" },
                    { 8, "5", "Just Rat", "pink and grey", "loves to climb", "Med-Low", "Small things", 3f, "Perfect", "Rat" },
                    { 9, "7", "Rat Terrier", "white with brown spots, or is it brown with white spots", "can be nice when food is available", "Highest", "me", 4f, "Perfect", "Dog" },
                    { 10, "10", "Roo", "Yellow", "loyal and honest", "Normal", "Everyone", 2f, "Perfect", "Kangaroo" }
                });
        }
    }
}
