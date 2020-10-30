using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Dolzhnosti
    {
        [Display(Name = "Требования")]
        public string Trebovaniya { get; set; }
        [Display(Name = "Обязанности")]
        public string Obyazannosti { get; set; }
        [Display(Name = "Оклад")]
        public int Oklad { get; set; }
        [Display(Name = "Наименование")]
        public string Name_dolzhnosti { get; set; }
        [Display(Name = "Код должности")]
        public long ID { get; set; }
    }
}
