﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821220744_CatsAndDogs")]
    partial class CatsAndDogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
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

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = "1",
                            Breed = "British Shorthair",
                            Coloring = "Yellow",
                            Disposition = "super sweet",
                            EnergyLevel = "High",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 2,
                            Age = "4",
                            Breed = "Maine Coon",
                            Coloring = "Black",
                            Disposition = "super sweet but bitey",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Small dogs",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 3,
                            Age = "7",
                            Breed = "Rag doll",
                            Coloring = "speckled",
                            Disposition = "lays around",
                            EnergyLevel = "Low",
                            GetsAlongWith = "Handler",
                            NumOfFeet = 3f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 4,
                            Age = "1",
                            Breed = "Sphynx",
                            Coloring = "Beige with Black muzzle",
                            Disposition = "super sweet",
                            EnergyLevel = "Slothlike",
                            GetsAlongWith = "big dogs, friends",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 5,
                            Age = "6 months",
                            Breed = "Bengal",
                            Coloring = "pink with black spots",
                            Disposition = "wants cuddles forever",
                            EnergyLevel = "Bouncy",
                            GetsAlongWith = "Children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 6,
                            Age = "3",
                            Breed = "Persian",
                            Coloring = "Yellow with spots",
                            Disposition = "rough and tumble",
                            EnergyLevel = "Chill",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 7,
                            Age = "1",
                            Breed = "Siamese",
                            Coloring = "Grey/Silver",
                            Disposition = "bouncey and happy",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Adults and random strangers",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 8,
                            Age = "5",
                            Breed = "American Shorthair",
                            Coloring = "pink and grey",
                            Disposition = "loves to climb",
                            EnergyLevel = "Med-Low",
                            GetsAlongWith = "Small things",
                            NumOfFeet = 3f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 9,
                            Age = "7",
                            Breed = "Abyssinian",
                            Coloring = "white with brown spots, or is it brown with white spots",
                            Disposition = "can be nice when food is available",
                            EnergyLevel = "Highest",
                            GetsAlongWith = "me",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            CatId = 10,
                            Age = "10",
                            Breed = "Russian Blue",
                            Coloring = "Yellow",
                            Disposition = "loyal and honest",
                            EnergyLevel = "Normal",
                            GetsAlongWith = "Everyone",
                            NumOfFeet = 2f,
                            Size = "Perfect"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
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

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = "1",
                            Breed = "Golden Retriever",
                            Coloring = "Yellow",
                            Disposition = "super sweet",
                            EnergyLevel = "High",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 2,
                            Age = "4",
                            Breed = "Labrador Retriever",
                            Coloring = "Black",
                            Disposition = "super sweet but bitey",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Small dogs",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 3,
                            Age = "7",
                            Breed = "French Bulldog",
                            Coloring = "speckled",
                            Disposition = "lays around",
                            EnergyLevel = "Low",
                            GetsAlongWith = "Handler",
                            NumOfFeet = 3f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 4,
                            Age = "1",
                            Breed = "Pug",
                            Coloring = "Beige with Black muzzle",
                            Disposition = "super sweet",
                            EnergyLevel = "Slothlike",
                            GetsAlongWith = "big dogs, friends",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 5,
                            Age = "6 months",
                            Breed = "Affenpinscher",
                            Coloring = "pink with black spots",
                            Disposition = "wants cuddles forever",
                            EnergyLevel = "Bouncy",
                            GetsAlongWith = "Children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 6,
                            Age = "3",
                            Breed = "Poodle",
                            Coloring = "Yellow with spots",
                            Disposition = "rough and tumble",
                            EnergyLevel = "Chill",
                            GetsAlongWith = "Small dogs, children",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 7,
                            Age = "1",
                            Breed = "Weimeraner",
                            Coloring = "Grey/Silver",
                            Disposition = "bouncey and happy",
                            EnergyLevel = "Medium",
                            GetsAlongWith = "Adults and random strangers",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 8,
                            Age = "5",
                            Breed = "Chihuahua",
                            Coloring = "pink and grey",
                            Disposition = "loves to climb",
                            EnergyLevel = "Med-Low",
                            GetsAlongWith = "Small things",
                            NumOfFeet = 3f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 9,
                            Age = "7",
                            Breed = "Rat Terrier",
                            Coloring = "white with brown spots, or is it brown with white spots",
                            Disposition = "can be nice when food is available",
                            EnergyLevel = "Highest",
                            GetsAlongWith = "me",
                            NumOfFeet = 4f,
                            Size = "Perfect"
                        },
                        new
                        {
                            DogId = 10,
                            Age = "10",
                            Breed = "Great Dane",
                            Coloring = "Yellow",
                            Disposition = "loyal and honest",
                            EnergyLevel = "Normal",
                            GetsAlongWith = "Everyone",
                            NumOfFeet = 2f,
                            Size = "Perfect"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
