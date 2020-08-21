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
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;
    private readonly AnimalShelterContext context;
    private readonly IUriService uriService;
    public CatsController(AnimalShelterContext db, IUriService uriService, AnimalShelterContext context)

    {
      _db = db;
      this.context = context;
      this.uriService = uriService;
    }
    // GET api/cats by query
    [HttpGet("search")]
    public ActionResult<IEnumerable<Cat>> Get(string energyLevel, string size, string getsAlongWith, string breed, string age, string disposition, string coloring)
    {
      var query = _db.Cats.AsQueryable();

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
      var pagedData = _db.Cats.ToList()
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToList();
      var totalRecords = _db.Cats.Count();
      var pagedResponse = PaginationHelper.CreatePagedResponse<Cat>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedResponse);
    }

    // GET api/cats/5
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    // POST api/cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    // PUT api/cats/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/cats/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}
