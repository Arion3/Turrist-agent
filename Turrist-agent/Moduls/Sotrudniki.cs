using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Sotrudniki
    {
        [Display(Name ="Код сотрудника")]
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Возраст")]
        public int Vozrast { get; set; }
        [Display(Name = "Пол")]
        public string Pol { get; set; }
        [Display(Name = "Адрес")]
        public string Adres { get; set; }
        [Display(Name = "Телефон")]
        public string Telefon { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Pass_dannie { get; set; }
        [Display(Name = "Код должности")]
        public long Kod_dolzhnosti { get; set; }
        [Display(Name = "Должность")]
        public DbSet<Dolzhnosti> Dolzhnosti { get; set; }


    }
}
