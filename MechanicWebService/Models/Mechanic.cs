using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Mechanic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmployeeID { get; set; }
        public string Experiance { get; set; }
    }
}
