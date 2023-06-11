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
  public async Task<ActionResult<IEnumerable<Animal>>> GetAsync(string species)
  {
    IQueryable<Animal> query = _db.Animals.AsQueryable();

    if (species != null)
    {
      query = query.Where(entry => entry.Species == species);
    }

    return await query.ToListAsync();
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
  public async Task<ActionResult<Animal>> PostAsync(Animal animal)
  {
    _db.Animals.Add(animal);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetAnimalAsync), new { id = animal.AnimalId }, animal);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> PutAsync(int id, Animal animal)
  {
    if (id != animal.AnimalId)
    {
      return BadRequest();
    }

    _db.Animals.Update(animal);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!AnimalExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }

    return NoContent();
  }

  private bool AnimalExists(int id)
  {
    return _db.Animals.Any(e => e.AnimalId == id);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteAnimalAsync(int id)
  {
    Animal animal = await _db.Animals.FindAsync(id);
    if (animal == null)
    {
      return NotFound();
    }

    _db.Animals.Remove(animal);
    await _db.SaveChangesAsync();

    return NoContent();
  }




}