using Microsoft.EntityFrameworkCore;
using RendezvousService.Models;

namespace RendezvousService.Data
{
    public class RendezvousDbContext : DbContext
    {
        public RendezvousDbContext(DbContextOptions<RendezvousDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Rendezvous> Rendezvouss { get; set; }
    }
}
