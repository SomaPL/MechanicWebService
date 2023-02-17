using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Car
    {
        private const string V = "Pole Wymagane";

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name ="Model")]
        public string Model { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Marka")]
        public string Mark { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "VIN")]
        public string VIN { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Rok Produkcji")]
        public string Year { get; set; }

    }
}
