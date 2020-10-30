using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Klienti
    {
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime Data_rozhdeniya { get; set; }
        [Display(Name = "Пол")]
        public string Pol { get; set; }
        [Display(Name = "Адрес")]
        public string adres { get; set; }
        [Display(Name = "Телефон")]
        public string telefon { get; set; }
        [Display(Name = "Пасспортные данные")]
        public string pass_dannie { get; set; }

    }
}
