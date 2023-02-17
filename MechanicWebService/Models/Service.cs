﻿using System.ComponentModel.DataAnnotations;

namespace MechanicWebService.Models
{
    public class Service
    {
        private const string V = "Pole Wymagane";
        public int ServiceId { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required(ErrorMessage = V)]
        [Display(Name = "Koszt")]
        public decimal Price { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
