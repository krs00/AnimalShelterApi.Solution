using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
  private readonly AnimalShelterApiContext _db;

  public AnimalsController(AnimalShelterApiContext db)
  {
    _db = db;
  }


  [HttpGet]
  public async Task<ActionResult<IEnumerable<Animal>>> GetAsync()
  {
    return await _db.Animals.ToListAsync();
  }


  [HttpGet("{id}")]
  public async Task<ActionResult<Animal>> GetAnimalAsync(int id)
  {
    Animal animal = await _db.Animals.FindAsync(id);

    // ERROR HANDLING
    if (animal == null)
    {
      return NotFound();
    }

    return animal;
  }

  [HttpPost]
  public async Task<ActionResult<Animal>> Post(Animal animal)
  {
    _db.Animals.Add(animal);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetAnimalAsync), new { id = animal.AnimalId }, animal);
  }


}