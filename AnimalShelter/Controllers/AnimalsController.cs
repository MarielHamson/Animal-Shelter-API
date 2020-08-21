﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    // GET api/animals
    [HttpGet]
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
