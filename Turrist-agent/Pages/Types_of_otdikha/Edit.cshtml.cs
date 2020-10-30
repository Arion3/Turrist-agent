﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Types_of_otdikha
{
    public class EditModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public EditModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Types_of_otdizha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Types_of_otdizhaExists(Types_of_otdizha.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Types_of_otdizhaExists(long id)
        {
            return _context.Types_of_otdizha.Any(e => e.ID == id);
        }
    }
}
