using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class ReSeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "4", "Labrador Retriever", "Black", "super sweet but bitey", "Small dogs" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "7", "Iguana", "speckled", "lays around", "Handler", 3f, "Lizard" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Breed", "Coloring", "GetsAlongWith" },
                values: new object[] { "Pug", "Beige with Black muzzle", "big dogs, friends" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "Type" },
                values: new object[] { "6 months", "Potbelly", "pink with black spots", "wants cuddles forever", "Children", "Pig" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "Type" },
                values: new object[] { "3", "Leopard", "Yellow with spots", "rough and tumble", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                columns: new[] { "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "Weimeraner", "Grey/Silver", "bouncey and happy", "Adults and random strangers" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "5", "Just Rat", "pink and grey", "loves to climb", "Small things", 3f, "Rat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "7", "Rat Terrier", "white with brown spots, or is it brown with white spots", "can be nice when food is available", "me" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                columns: new[] { "Age", "Breed", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "10", "Roo", "loyal and honest", "Everyone", 2f, "Kangaroo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Small dogs, children" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Small dogs, children", 4f, "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Breed", "Coloring", "GetsAlongWith" },
                values: new object[] { "Golden Retriever", "Yellow", "Small dogs, children" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "Type" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Small dogs, children", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "Type" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                columns: new[] { "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "Golden Retriever", "Yellow", "super sweet", "Small dogs, children" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Small dogs, children", 4f, "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                columns: new[] { "Age", "Breed", "Coloring", "Disposition", "GetsAlongWith" },
                values: new object[] { "1", "Golden Retriever", "Yellow", "super sweet", "Small dogs, children" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                columns: new[] { "Age", "Breed", "Disposition", "GetsAlongWith", "NumOfFeet", "Type" },
                values: new object[] { "1", "Golden Retriever", "super sweet", "Small dogs, children", 4f, "Dog" });
        }
    }
}
