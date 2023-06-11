using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    [Required]
    public string Sex { get; set; }
    [Required]
    public string Status { get; set; }


  }
}