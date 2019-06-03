using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PickEm.Models
{
    public class PickEmContext : DbContext
    {
        public PickEmContext (DbContextOptions<PickEmContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamModel>()
                .HasMany(t => t.HomeGames)
                .WithOne(g => g.HomeTeam)
                .HasForeignKey(g => g.HomeTeamId);
            
            modelBuilder.Entity<TeamModel>()
                .HasMany(t => t.AwayGames)
                .WithOne(g => g.AwayTeam)
                .HasForeignKey(g => g.AwayTeamId);

            modelBuilder.Entity<BracketModel>()
                .HasMany(b => b.Games)
                .WithOne(g => g.Bracket)
                .HasForeignKey(g => g.BracketId);
        }

        public DbSet<PickEm.Models.TeamModel> TeamModel { get; set; }
        public DbSet<PickEm.Models.GameModel> GameModel { get; set; }
        public DbSet<PickEm.Models.BracketModel> BracketModel { get; set; }
    }
}