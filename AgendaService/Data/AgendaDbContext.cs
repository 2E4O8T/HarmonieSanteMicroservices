using AgendaService.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaService.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
        {

        }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }
    }
}
