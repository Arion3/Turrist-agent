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
    public class IndexModel : PageModel
    {
        private readonly Turrist_agent.Data.Turrist_agentContext _context;

        public IndexModel(Turrist_agent.Data.Turrist_agentContext context)
        {
            _context = context;
        }

        public IList<Dolzhnosti> Dolzhnosti { get;set; }

        public async Task OnGetAsync()
        {
            Dolzhnosti = await _context.Dolzhnosti.ToListAsync();
        }
    }
}
