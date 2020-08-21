using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options) {}

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Tom", Age = 3, Species = "Cat", Gender = "Male", Fixed = true },
          new Animal { AnimalId = 2, Name = "Lady", Age = 9, Species = "Dog", Gender = "Female", Fixed = true },
          new Animal { AnimalId = 3, Name = "Pluto", Age = 1, Species = "Dog", Gender = "Male", Fixed = false }
        );
    }
  }
}