using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Koszt")]
        public decimal Price { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
