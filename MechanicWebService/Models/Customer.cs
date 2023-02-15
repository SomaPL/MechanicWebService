using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Numer Telefonu")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Addres")]
        public string Address { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
