using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Mark { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Year { get; set; }

    }
}
