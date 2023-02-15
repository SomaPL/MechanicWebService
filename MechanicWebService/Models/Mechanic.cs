using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Mechanic
    {
        [Key]
        public int MechanicId { get; set; }
        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Doświadczenie")]
        public string Experiance { get; set; }
        [Display(Name = "Specjalizacja")]
        public string Specialization { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

