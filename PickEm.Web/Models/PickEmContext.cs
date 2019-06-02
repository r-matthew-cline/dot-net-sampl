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

        public DbSet<PickEm.Models.TeamModel> TeamModel { get; set; }
        public DbSet<PickEm.Models.GameModel> GameModel { get; set; }

        public DbSet<PickEm.Models.BracketModel> BracketModel { get; set; }

    }
}