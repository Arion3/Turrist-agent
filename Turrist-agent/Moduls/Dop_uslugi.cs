using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Dop_uslugi
    {
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }
        [Display(Name = "Цена")]
        public int Cena { get; set; }
        [Display(Name = "Описание")]
        public string Opisanie { get; set; }

    }
}
