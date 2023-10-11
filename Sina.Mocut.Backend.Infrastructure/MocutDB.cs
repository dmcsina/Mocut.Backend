using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sina.Mocut.Backend.Core.Entitis;

namespace Sina.Mocut.Backend.Infrastructure
{
    public class MocutDB : DbContext
    {
        public DbSet<Barber> Barbers { get; set; }
        public DbSet<BarberOwner> BarberOwners { get; set; }
        public DbSet<Counter> counters { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<SystemManagement> systemManagements { get; set; }
        public MocutDB(DbContextOptions<MocutDB>options)
            : base(options)
        {
        }

    }
}
