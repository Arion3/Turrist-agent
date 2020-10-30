using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Types_of_otdikha
{
    public class DetailsModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public DetailsModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        public Types_of_otdizha Types_of_otdizha { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Types_of_otdizha = await _context.Types_of_otdizha.FirstOrDefaultAsync(m => m.ID == id);

            if (Types_of_otdizha == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
