using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Marka")]
        public string Mark { get; set; }
        [Required]
        [Display(Name = "VIN")]
        public string VIN { get; set; }
        [Required]
        [Display(Name = "Rok Produkcji")]
        public string Year { get; set; }

    }
}
