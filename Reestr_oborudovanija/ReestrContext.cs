using Microsoft.EntityFrameworkCore;
using Reestr_oborudovanija.Models;

namespace Reestr_oborudovanija
{
    public class ReestrContext: DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Status> Statuses { get; set; }


        public ReestrContext(DbContextOptions<ReestrContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.State)
                .WithMany(s => s.Equipments)
                .HasForeignKey(e => e.State_id);
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Status)
                .WithMany(s => s.Equipments)
                .HasForeignKey(e => e.Status_id);
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Storage)
                .WithMany(s => s.Equipments)
                .HasForeignKey(e => e.Storage_id);
        }
    }
}
