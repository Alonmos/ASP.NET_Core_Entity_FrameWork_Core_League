//using inter.Migrations;
using inter.Models;
using inter.Models.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection;

namespace inter.Data
{
    public class leagueDBContext :DbContext
    {
        public leagueDBContext (DbContextOptions options) : base (options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            Seeds.Seed(modelBuilder);
        }

        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Scouts> Scouts { get; set; }
        public DbSet <Managers> Managers{ get; set; }
        public DbSet<ScoutsTeams> ScoutsTeams { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Agents> Agents { get; set; }

    }
}
