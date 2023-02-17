using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Mechanic
    {
        private const string V = "Pole Wymagane";
        [Key]
        public int MechanicId { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Doświadczenie")]
        public string Experiance { get; set; }
        [Display(Name = "Specjalizacja")]
        public string Specialization { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

