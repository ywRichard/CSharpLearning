using System;
using System.Data.Entity;

namespace _00_NewMVCProj.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseTime { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class GameDBContext:DbContext
    {
        public DbSet<Game> Games { get; set; }
    }

}