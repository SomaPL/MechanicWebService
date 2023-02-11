using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
