namespace MechanicWebService.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int MechanicId { get; set; }
        public int ServiceId { get; set; }
        public DateTime DateAndTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
