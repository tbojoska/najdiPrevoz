using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace najdiPrevoz.Models
{
    public class Reservation
    {
        [Key] public long Id { get; set; }

        public string Status { get; set; }
  
        public string Traveler { get; set; }

        public long TripId { get; set; }

        public string Creator { get; set; }

        public int NoSeats { get; set; }

        [Required]
        [Display(Name = "Почетна дестинација")]
        public string FromDestination { get; set; }

        [Required]
        [Display(Name = "Крајна дестинација")]
        public string ToDestination { get; set; }

        [Required]
        [Display(Name = "Датум (DD.MM.YYYY)")]
        [RegularExpression(@"([0-2][0-9].[0-1][0-9].[2][0][2-3][0-3])")]
        public string Time { get; set; }

        [Required]
        [Display(Name = "Време (HH:MM)")]
        [RegularExpression(@"[0-2][0-9]:[0-5][0-9]")]
        public string TimeHourMin { get; set; }

        [Display(Name = "Цена по патник")]
        public int Price { get; set; }
    }
}