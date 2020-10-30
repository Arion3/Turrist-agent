using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Oteli
    {
        
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }
        [Display(Name = "Страна")]
        public string Strana { get; set; }
        [Display(Name = "Город")]
        public string gorod { get; set; }
        [Display(Name = "Адрес")]
        public string adres { get; set; }
        [Display(Name = "Телефон")]
        public string Telefon { get; set; }
        [Display(Name = "Количество звёзд")]
        public int Kolvo_zvezd { get; set; }
        [Display(Name = "Контактное лицо")]
        public string kontact_Lico { get; set; }
    }
}
