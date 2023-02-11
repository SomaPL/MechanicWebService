using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Mechanic
    {
        [Key]
        public int MechanicId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Experiance { get; set; }
        public string Specialization { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

