using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {

    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, EnergyLevel = "High", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 2, EnergyLevel = "Medium", GetsAlongWith = "Small dogs", Type = "Dog", Breed = "Labrador Retriever", Age = "4", Disposition = "super sweet but bitey", Coloring = "Black", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 3, EnergyLevel = "Low", GetsAlongWith = "Handler", Type = "Lizard", Breed = "Iguana", Age = "7", Disposition = "lays around", Coloring = "speckled", NumOfFeet = 3, Size = "Perfect" },
          new Animal { AnimalId = 4, EnergyLevel = "Slothlike", GetsAlongWith = "big dogs, friends", Type = "Dog", Breed = "Pug", Age = "1", Disposition = "super sweet", Coloring = "Beige with Black muzzle", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 5, EnergyLevel = "Bouncy", GetsAlongWith = "Children", Type = "Pig", Breed = "Potbelly", Age = "6 months", Disposition = "wants cuddles forever", Coloring = "pink with black spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 6, EnergyLevel = "Chill", GetsAlongWith = "Small dogs, children", Type = "Cat", Breed = "Leopard", Age = "3", Disposition = "rough and tumble", Coloring = "Yellow with spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 7, EnergyLevel = "Medium", GetsAlongWith = "Adults and random strangers", Type = "Dog", Breed = "Weimeraner", Age = "1", Disposition = "bouncey and happy", Coloring = "Grey/Silver", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 8, EnergyLevel = "Med-Low", GetsAlongWith = "Small things", Type = "Rat", Breed = "Just Rat", Age = "5", Disposition = "loves to climb", Coloring = "pink and grey", NumOfFeet = 3, Size = "Perfect" },
          new Animal { AnimalId = 9, EnergyLevel = "Highest", GetsAlongWith = "me", Type = "Dog", Breed = "Rat Terrier", Age = "7", Disposition = "can be nice when food is available", Coloring = "white with brown spots, or is it brown with white spots", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 10, EnergyLevel = "Normal", GetsAlongWith = "Everyone", Type = "Kangaroo", Breed = "Roo", Age = "10", Disposition = "loyal and honest", Coloring = "Yellow", NumOfFeet = 2, Size = "Perfect" });
    }
  }
}