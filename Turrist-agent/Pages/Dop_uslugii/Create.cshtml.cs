﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Turrist_agent.Data;
using Turrist_agent.Moduls;

namespace Turrist_agent.Pages.Dop_uslugii
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
        public Dop_uslugi Dop_uslugi { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dop_uslugi.Add(Dop_uslugi);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
