using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace najdiPrevoz.Models
{
    public class Trip
    {
        [Key]
        public long Id { get; set; }

        public string Creator { get; set; }

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


        [Required]
        [Display(Name = "Вкупен број на седишта ")]
        public int Capacity { get; set; }

        [Display(Name = "Број на слободни седишта ")]
        public int FreeSeats { get; set; }


        [Display(Name = "Опис на патувањето")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Опис на возилото (марка и година на производство)")]
        public string AutoDescr { get; set; }

        [Display(Name = "Слика од возилото")]
        public string Img { get; set; }


        [NotMapped]
        public bool CanEdit { get; set; }

        [Display(Name = "Цена по патник")]
        public int Price { get; set; }

    }
}
    public enum Gradovi
    {
        Скопје, Битола, Куманово, Прилеп, Тетово, Велес, Охрид, Штип, Гостивар, Струмица, Кичево, Кавадарци, Кочани, 
        ДемирКапија, Неготино, СветиНиколе, Берово, Виница, Делчево, МакедонскаКаменица, Пехчево, Пробиштип,
        Дебар, МакедонскиБрод, Струга, Богданци, Валандово, Гевгелија, Радовиш, ДемирХисар, Крушево, Ресен,
        Кратово, КриваПаланка
    }

    
