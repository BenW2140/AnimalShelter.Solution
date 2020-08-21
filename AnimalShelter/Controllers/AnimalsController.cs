using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [ApiVersion("1.0")]
  [ApiController]
  [Route("api/[controller]")]
  public class AnimalsController : Controller
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name, string species, string gender)
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      var animal = await _db.Animals.Where(a => a.AnimalId == id).FirstOrDefaultAsync();
      return Ok(new Response<Animal>(animal));
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}