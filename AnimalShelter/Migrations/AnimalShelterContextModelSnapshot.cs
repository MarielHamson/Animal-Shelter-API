﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age")
                        .IsRequired();

                    b.Property<string>("Breed")
                        .IsRequired();

                    b.Property<string>("Coloring")
                        .IsRequired();

                    b.Property<string>("Disposition")
                        .IsRequired();

                    b.Property<string>("EnergyLevel")
                        .IsRequired();

                    b.Property<string>("GetsAlongWith")
                        .IsRequired();

                    b.Property<float>("NumOfFeet");

                    b.Property<string>("Size")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = "1",
                            Breed = "Golden Retriever",
                            Coloring = "Yellow",
                            Disposition = "super sweet",
                            EnergyLevel = "High",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = "4",
                            Breed = "Labrador Retriever",
                            Coloring = "Black",
                            Disposition = "super sweet but bitey",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Small dogs",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = "7",
                            Breed = "Iguana",
                            Coloring = "speckled",
                            Disposition = "lays around",
                            EnergyLevel = "Low",
                            GetsAlongWith = "Handler",
                            NumOfFeet = 3f,
                            Size = "Perfect",
                            Type = "Lizard"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = "1",
                            Breed = "Pug",
                            Coloring = "Beige with Black muzzle",
                            Disposition = "super sweet",
                            EnergyLevel = "Slothlike",
                            GetsAlongWith = "big dogs, friends",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = "6 months",
                            Breed = "Potbelly",
                            Coloring = "pink with black spots",
                            Disposition = "wants cuddles forever",
                            EnergyLevel = "Bouncy",
                            GetsAlongWith = "Children",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Pig"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = "3",
                            Breed = "Leopard",
                            Coloring = "Yellow with spots",
                            Disposition = "rough and tumble",
                            EnergyLevel = "Chill",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = "1",
                            Breed = "Weimeraner",
                            Coloring = "Grey/Silver",
                            Disposition = "bouncey and happy",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Adults and random strangers",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = "5",
                            Breed = "Just Rat",
                            Coloring = "pink and grey",
                            Disposition = "loves to climb",
                            EnergyLevel = "Med-Low",
                            GetsAlongWith = "Small things",
                            NumOfFeet = 3f,
                            Size = "Perfect",
                            Type = "Rat"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = "7",
                            Breed = "Rat Terrier",
                            Coloring = "white with brown spots, or is it brown with white spots",
                            Disposition = "can be nice when food is available",
                            EnergyLevel = "Highest",
                            GetsAlongWith = "me",
                            NumOfFeet = 4f,
                            Size = "Perfect",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = "10",
                            Breed = "Roo",
                            Coloring = "Yellow",
                            Disposition = "loyal and honest",
                            EnergyLevel = "Normal",
                            GetsAlongWith = "Everyone",
                            NumOfFeet = 2f,
                            Size = "Perfect",
                            Type = "Kangaroo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
