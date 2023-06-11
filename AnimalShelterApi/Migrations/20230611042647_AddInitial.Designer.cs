﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230611042647_AddInitial")]
    partial class AddInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 1,
                            Breed = "Ragdoll",
                            Name = "Max",
                            Sex = "Male",
                            Species = "Cat",
                            Status = "Available"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Breed = "Persian",
                            Name = "Luna",
                            Sex = "Female",
                            Species = "Cat",
                            Status = "Available"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Breed = "Siamese",
                            Name = "Lily",
                            Sex = "Female",
                            Species = "Cat",
                            Status = "Available"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 3,
                            Breed = "Bulldog",
                            Name = "Bear",
                            Sex = "Male",
                            Species = "Dog",
                            Status = "Available"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 5,
                            Breed = "Border Collie",
                            Name = "Duke",
                            Sex = "Male",
                            Species = "Dog",
                            Status = "Available"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 2,
                            Breed = "Akita",
                            Name = "Milo",
                            Sex = "Male",
                            Species = "Dog",
                            Status = "Available"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
