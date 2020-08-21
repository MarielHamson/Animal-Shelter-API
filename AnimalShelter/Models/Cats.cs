using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Cat
  {

    public int CatId { get; set; }
    [Required]
    public string EnergyLevel { get; set; }
    [Required]
    public string GetsAlongWith { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public string Age { get; set; }
    [Required]
    public string Disposition { get; set; }
    [Required]
    public string Coloring { get; set; }
    [Range(0, 1000, ErrorMessage = "Must be between 1 and 1000.")]
    public float NumOfFeet { get; set; }
    [Required]
    public string Size { get; set; }
  }
}