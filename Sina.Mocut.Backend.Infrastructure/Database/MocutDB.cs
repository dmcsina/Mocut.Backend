using Microsoft.EntityFrameworkCore;
using Sina.Mocut.Backend.Core.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sina.Mocut.Backend.Infrastructure.Database
{
    public class MocutDB : DbContext
    {
        public DbSet<Barber> barbers { get; set; }
        public DbSet<BarberOwner> barberOwners { get; set; }
        public DbSet<Counter> counters { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<SystemManagement> systemManagements { get; set; }

        public MocutDB(DbContextOptions<MocutDB> options)
            :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Barber>().HasKey(m => m.PhoneNumber);
            modelBuilder.Entity<BarberOwner>().HasKey(m => m.Username);
            modelBuilder.Entity<Counter>().HasKey(m => m.Id);
            modelBuilder.Entity<Customer>().HasKey(m => m.Phonenumber);
            modelBuilder.Entity<SystemManagement>().HasKey(m => m.Username);
        }
    }
}
