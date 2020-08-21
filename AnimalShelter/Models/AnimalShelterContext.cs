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
          new Animal { AnimalId = 2, EnergyLevel = "Medium", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 3, EnergyLevel = "Low", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 4, EnergyLevel = "Slothlike", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 5, EnergyLevel = "Bouncy", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 6, EnergyLevel = "Chill", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 7, EnergyLevel = "Medium", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 8, EnergyLevel = "Med-Low", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 9, EnergyLevel = "Highest", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" },
          new Animal { AnimalId = 10, EnergyLevel = "Normal", GetsAlongWith = "Small dogs, children", Type = "Dog", Breed = "Golden Retriever", Age = "1", Disposition = "super sweet", Coloring = "Yellow", NumOfFeet = 4, Size = "Perfect" });
    }
  }
}