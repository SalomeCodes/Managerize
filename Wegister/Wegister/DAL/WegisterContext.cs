using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wegister.Models;

namespace Wegister.DAL
{
    public class WegisterContext : DbContext
    {
        public WegisterContext(DbContextOptions<WegisterContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<HourRegistration> HourRegistrations { get; set; } 
    }
}
