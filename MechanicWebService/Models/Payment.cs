using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MechanicWebService.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [Display(Name = "Numer Rezerwacji")]
        public int ReservationId { get; set; }
        [Display(Name = "Metoda Płatności")]
        public string PaymentMethod { get; set; }
        [Display(Name = "Należność")]
        public decimal Amount { get; set; }

        [Display(Name = "Rezerwacja")]
        public virtual Reservation Reservation { get; set; }
    }
}
