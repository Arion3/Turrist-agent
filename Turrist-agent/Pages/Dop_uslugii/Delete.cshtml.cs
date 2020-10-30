using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Dop_uslugii
{
    public class DeleteModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public DeleteModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dop_uslugi Dop_uslugi { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dop_uslugi = await _context.Dop_uslugi.FirstOrDefaultAsync(m => m.ID == id);

            if (Dop_uslugi == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dop_uslugi = await _context.Dop_uslugi.FindAsync(id);

            if (Dop_uslugi != null)
            {
                _context.Dop_uslugi.Remove(Dop_uslugi);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
