﻿namespace MechanicWebService.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        
        public virtual Reservation Reservation { get; set; }
    }
}
