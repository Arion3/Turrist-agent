using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Dolzhnostii
{
    public class DetailsModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public DetailsModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        public Dolzhnosti Dolzhnosti { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dolzhnosti = await _context.Dolzhnosti.FirstOrDefaultAsync(m => m.ID == id);

            if (Dolzhnosti == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
