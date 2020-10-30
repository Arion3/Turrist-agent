using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Turrist_agent.Moduls
{
    public class Types_of_otdizha
    {
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }
        [Display(Name = "Ограничения")]
        public string Ogranicheniya { get; set; }
        [Display(Name = "Описание")]
        public string Opisanie { get; set; }
    }
}
