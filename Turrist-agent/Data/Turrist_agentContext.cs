using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turrist_agent.Moduls;

namespace Turrist_agent.Data
{
    public class Turrist_agentContext : DbContext
    {
        public Turrist_agentContext (DbContextOptions<Turrist_agentContext> options)
            : base(options)
        {
        }

        public DbSet<Turrist_agent.Moduls.Dolzhnosti> Dolzhnosti { get; set; }

        public DbSet<Turrist_agent.Moduls.Sotrudniki> Sotrudniki { get; set; }

        public DbSet<Turrist_agent.Moduls.Types_of_otdizha> Types_of_otdizha { get; set; }

        public DbSet<Turrist_agent.Moduls.Oteli> Oteli { get; set; }

        public DbSet<Turrist_agent.Moduls.Dop_uslugi> Dop_uslugi { get; set; }

        public DbSet<Turrist_agent.Moduls.Klienti> Klienti { get; set; }

        public DbSet<Turrist_agent.Moduls.Putevki> Putevki { get; set; }
    }
}
