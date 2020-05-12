using Fullstuck.EnergieService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fullstuck.EnergieService.DAL
{
    public class EnergystuckContext : DbContext 
    {
        public EnergystuckContext(DbContextOptions<EnergystuckContext> options)
            :base(options) {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<EnergieMeting> EnergieMeting { get; set; }
        public DbSet<Energiemeter> Energiemeter { get; set; }
    }
}
