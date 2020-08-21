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
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;
    private readonly AnimalShelterContext context;
    private readonly IUriService uriService;
    public DogsController(AnimalShelterContext db, IUriService uriService, AnimalShelterContext context)

    {
      _db = db;
      this.context = context;
      this.uriService = uriService;
    }
    // GET api/dogs by query
    [HttpGet("search")]
    public ActionResult<IEnumerable<Dog>> Get(string energyLevel, string size, string getsAlongWith, string breed, string age, string disposition, string coloring)
    {
      var query = _db.Dogs.AsQueryable();

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
      var pagedData = _db.Dogs.ToList()
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToList();
      var totalRecords = _db.Dogs.Count();
      var pagedResponse = PaginationHelper.CreatePagedResponse<Dog>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedResponse);
    }

    // GET api/dogs/5
    [HttpGet("{id}")]
    public ActionResult<Dog> Get(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }

    // POST api/dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    // PUT api/dogs/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/dogs/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}
