using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Customer
    {
        private const string V = "Pole Wymagane";
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Numer Telefonu")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Addres")]
        public string Address { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
