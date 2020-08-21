using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using AnimalShelter.Services;


namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;
    private readonly AnimalShelterContext context;
    private readonly IUriService uriService;
    public AnimalsController(AnimalShelterContext db, IUriService uriService, AnimalShelterContext context)

    {
      _db = db;
      this.context = context;
      this.uriService = uriService;
    }
    // GET api/animals by query
    [HttpGet("search")]
    public ActionResult<IEnumerable<Animal>> Get(string energyLevel, string size, string getsAlongWith, string type, string breed, string age, string disposition, string coloring)
    {
      var query = _db.Animals.AsQueryable();

      if (energyLevel != null)
      {
        query = query.Where(entry => entry.EnergyLevel.Contains(energyLevel));
      }
      if (size != null)
      {
        query = query.Where(entry => entry.Size.Contains(size));
      }
      if (getsAlongWith != null)
      {
        query = query.Where(entry => entry.GetsAlongWith.Contains(getsAlongWith));
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type.Contains(type));
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed.Contains(breed));
      }
      if (age != null)
      {
        query = query.Where(entry => entry.Age.Contains(age));
      }
      if (disposition != null)
      {
        query = query.Where(entry => entry.Disposition.Contains(disposition));
      }
      if (coloring != null)
      {
        query = query.Where(entry => entry.Coloring.Contains(coloring));
      }

      return query.ToList();
    }

    [HttpGet("")] //Get results by page
    public IActionResult GetAll([FromQuery] PaginationFilter filter)
    {
      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = _db.Animals.ToList()
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToList();
      var totalRecords = _db.Animals.Count();
      var pagedResponse = PaginationHelper.CreatePagedResponse<Animal>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedResponse);
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}
