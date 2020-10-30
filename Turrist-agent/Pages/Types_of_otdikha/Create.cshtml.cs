using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Types_of_otdikha
{
    public class CreateModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public CreateModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Types_of_otdizha Types_of_otdizha { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Types_of_otdizha.Add(Types_of_otdizha);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
