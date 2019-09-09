using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameWebApp.Models;

namespace GameWebApp.Models
{
    public class GameWebAppContext : DbContext
    {
        public GameWebAppContext (DbContextOptions<GameWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GameWebApp.Models.GameRoom> GameRoom { get; set; }

        public DbSet<GameWebApp.Models.Player> Player { get; set; }
    }
}
