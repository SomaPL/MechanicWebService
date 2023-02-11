using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
