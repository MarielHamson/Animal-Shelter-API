using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {

    }

    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Animal> Animals { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, EnergyLevel = "High", GetsAlongWith = "Small dogs, children", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 2, EnergyLevel = "Medium", GetsAlongWith = "Small dogs", Breed = "Labrador Retriever", Age = "4", Disposition = "super sweet but bitey", Coloring = "Black", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 3, EnergyLevel = "Low", GetsAlongWith = "Handler", Breed = "French Bulldog", Age = "7", Disposition = "lays around", Coloring = "speckled", NumOfFeet = 3, Size = "Perfect" },
          new Dog { DogId = 4, EnergyLevel = "Slothlike", GetsAlongWith = "big dogs, friends", Breed = "Pug", Age = "1", Disposition = "super sweet", Coloring = "Beige with Black muzzle", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 5, EnergyLevel = "Bouncy", GetsAlongWith = "Children", Breed = "Affenpinscher", Age = "6 months", Disposition = "wants cuddles forever", Coloring = "pink with black spots", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 6, EnergyLevel = "Chill", GetsAlongWith = "Small dogs, children", Breed = "Poodle", Age = "3", Disposition = "rough and tumble", Coloring = "Yellow with spots", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 7, EnergyLevel = "Medium", GetsAlongWith = "Adults and random strangers", Breed = "Weimeraner", Age = "1", Disposition = "bouncey and happy", Coloring = "Grey/Silver", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 8, EnergyLevel = "Med-Low", GetsAlongWith = "Small things", Breed = "Chihuahua", Age = "5", Disposition = "loves to climb", Coloring = "pink and grey", NumOfFeet = 3, Size = "Perfect" },
          new Dog { DogId = 9, EnergyLevel = "Highest", GetsAlongWith = "me", Breed = "Rat Terrier", Age = "7", Disposition = "can be nice when food is available", Coloring = "white with brown spots, or is it brown with white spots", NumOfFeet = 4, Size = "Perfect" },
          new Dog { DogId = 10, EnergyLevel = "Normal", GetsAlongWith = "Everyone", Breed = "Great Dane", Age = "10", Disposition = "loyal and honest", Coloring = "Yellow", NumOfFeet = 2, Size = "Perfect" });

      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, EnergyLevel = "High", GetsAlongWith = "Small dogs, children", Breed = "British Shorthair", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 2, EnergyLevel = "Medium", GetsAlongWith = "Small dogs", Breed = "Maine Coon", Age = "4", Disposition = "super sweet but bitey", Coloring = "Black", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 3, EnergyLevel = "Low", GetsAlongWith = "Handler", Breed = "Rag doll", Age = "7", Disposition = "lays around", Coloring = "speckled", NumOfFeet = 3, Size = "Perfect" },
          new Cat { CatId = 4, EnergyLevel = "Slothlike", GetsAlongWith = "big dogs, friends", Breed = "Sphynx", Age = "1", Disposition = "super sweet", Coloring = "Beige with Black muzzle", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 5, EnergyLevel = "Bouncy", GetsAlongWith = "Children", Breed = "Bengal", Age = "6 months", Disposition = "wants cuddles forever", Coloring = "pink with black spots", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 6, EnergyLevel = "Chill", GetsAlongWith = "Small dogs, children", Breed = "Persian", Age = "3", Disposition = "rough and tumble", Coloring = "Yellow with spots", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 7, EnergyLevel = "Medium", GetsAlongWith = "Adults and random strangers", Breed = "Siamese", Age = "1", Disposition = "bouncey and happy", Coloring = "Grey/Silver", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 8, EnergyLevel = "Med-Low", GetsAlongWith = "Small things", Breed = "American Shorthair", Age = "5", Disposition = "loves to climb", Coloring = "pink and grey", NumOfFeet = 3, Size = "Perfect" },
          new Cat { CatId = 9, EnergyLevel = "Highest", GetsAlongWith = "me", Breed = "Abyssinian", Age = "7", Disposition = "can be nice when food is available", Coloring = "white with brown spots, or is it brown with white spots", NumOfFeet = 4, Size = "Perfect" },
          new Cat { CatId = 10, EnergyLevel = "Normal", GetsAlongWith = "Everyone", Breed = "Russian Blue", Age = "10", Disposition = "loyal and honest", Coloring = "Yellow", NumOfFeet = 2, Size = "Perfect" });

      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, EnergyLevel = "High", GetsAlongWith = "Small dogs, children", Type = "Lizard", Breed = "Iguana", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 2, EnergyLevel = "Medium", GetsAlongWith = "Small dogs", Type = "Octopus", Breed = "Oceanic", Age = "4", Disposition = "super sweet but bitey", Coloring = "Black", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 3, EnergyLevel = "Low", GetsAlongWith = "Handler", Type = "Red Panda", Breed = "Chinese", Age = "7", Disposition = "lays around", Coloring = "speckled", NumOfFeet = 3, Size = "Perfect" },
          new Animal { AnimalId = 4, EnergyLevel = "Slothlike", GetsAlongWith = "big dogs, friends", Type = "Bird", Breed = "Canary", Age = "1", Disposition = "super sweet", Coloring = "Beige with Black muzzle", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 5, EnergyLevel = "Bouncy", GetsAlongWith = "Children", Type = "Pig", Breed = "Potbelly", Age = "6 months", Disposition = "wants cuddles forever", Coloring = "pink with black spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 6, EnergyLevel = "Chill", GetsAlongWith = "Small dogs, children", Type = "Elephant", Breed = "African", Age = "3", Disposition = "rough and tumble", Coloring = "Yellow with spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 7, EnergyLevel = "Medium", GetsAlongWith = "Adults and random strangers", Type = "Snake", Breed = "Rattle", Age = "1", Disposition = "bouncey and happy", Coloring = "Grey/Silver", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 8, EnergyLevel = "Med-Low", GetsAlongWith = "Small things", Type = "Monster", Breed = "Loch Ness", Age = "5", Disposition = "loves to climb", Coloring = "pink and grey", NumOfFeet = 3, Size = "Perfect" },
          new Animal { AnimalId = 9, EnergyLevel = "Highest", GetsAlongWith = "me", Type = "Fox", Breed = "Red", Age = "7", Disposition = "can be nice when food is available", Coloring = "white with brown spots, or is it brown with white spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 10, EnergyLevel = "Normal", GetsAlongWith = "Everyone", Type = "Kangaroo", Breed = "Roo", Age = "10", Disposition = "loyal and honest", Coloring = "Yellow", NumOfFeet = 2, Size = "Perfect" });
    }
  }
}