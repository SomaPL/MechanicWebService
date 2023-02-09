using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class ServiceRequest
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Tytuł")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Mark { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Year { get; set; }
    }
}
