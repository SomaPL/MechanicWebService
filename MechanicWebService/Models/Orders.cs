using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderTitle { get; set; }
        [Required]
        public string CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
