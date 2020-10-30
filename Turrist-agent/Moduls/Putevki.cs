using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Putevki
    {
        [Display(Name = "Дата начала")]
        public DateTime data_nachala { get; set; }
        [Display(Name = "Дата окончания")]
        public DateTime data_okonchaniya { get; set; }
        [Display(Name = "Продолжительность")]
        public int prodolzhitelnost { get; set; }
        public long ID { get; set; }
        [Display(Name = "ID вида")]

        public int kod_vida { get; set; }
        [Display(Name = "ID услуги 1")]
        public int kod_uslugi_1 { get; set; }
        [Display(Name = "ID услуги 2")]
        public int kod_uslugi_2 { get; set; }
        [Display(Name = "ID услуги 3")]
        public int kod_uslugi_3 { get; set; }
        [Display(Name = "ID клиента")]
        public int kod_klienta { get; set; }
        [Display(Name = "ID сотрудника")]
        public int kod_sotrudnika { get; set; }
        [Display(Name = "Отметка о брони")]
        public string otmetka_o_broni { get; set; }
        [Display(Name = "Отметка о оплате")]
        public string otmetka_o_oplate { get; set; }
        [Display(Name = "Вид")]
        public DbSet<Types_of_otdizha>  vida { get; set; }
        [Display(Name = "Клиент")]
        public DbSet<Klienti> klienta { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Sotrudniki> sotrudnika{ get; set; }



    }
}
