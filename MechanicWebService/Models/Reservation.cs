using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MechanicWebService.Models
{
    public class Reservation
    {
        [Required]
        [Display(Name = "Numer Rezerwacji")]
        public int ReservationId { get; set; }
        [Required]
        [Display(Name = "Imię Klienta")]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Imię Mechanika")]
        public int MechanicId { get; set; }
        [Required]
        [Display(Name = "Nazwa Usługi")]
        public int ServiceId { get; set; }
        [Display(Name = "Data i Godzina")]
        public DateTime DateAndTime { get; set; }

        [Display(Name = "Imię Klienta")]
        public virtual Customer Customer { get; set; }
        [Display(Name = "Mechanik")]
        public virtual Mechanic Mechanic { get; set; }
        [Display(Name = "Usługa")]
        public virtual Service Service { get; set; }
        [Display(Name = "Płatność")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
