using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models;
public class AnimalShelterApiContext : DbContext
{
  public DbSet<Animal> Animals { get; set; }

  public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Animal>()
    .HasData(
				// THESE ARE CATS
        new Animal { AnimalId = 1, Name = "Max", Species = "Cat", Age = 1, Breed = "Ragdoll", Sex = "Male", Status = "Available" },
        new Animal { AnimalId = 2, Name = "Luna", Species = "Cat", Age = 2, Breed = "Persian", Sex = "Female", Status = "Available" },
        new Animal { AnimalId = 3, Name = "Lily", Species = "Cat", Age = 2, Breed = "Siamese", Sex = "Female", Status = "Available" },
				// THESE ARE DOGS
        new Animal { AnimalId = 4, Name = "Bear", Species = "Dog", Age = 3, Breed = "Bulldog", Sex = "Male", Status = "Available" },
        new Animal { AnimalId = 5, Name = "Duke", Species = "Dog", Age = 5, Breed = "Border Collie", Sex = "Male", Status = "Available" },
        new Animal { AnimalId = 6, Name = "Milo", Species = "Dog", Age = 2, Breed = "Akita", Sex = "Male", Status = "Available" }
    );

  }
}