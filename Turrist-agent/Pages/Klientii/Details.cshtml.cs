using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Klientii
{
    public class DetailsModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public DetailsModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        public Klienti Klienti { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Klienti = await _context.Klienti.FirstOrDefaultAsync(m => m.ID == id);

            if (Klienti == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
