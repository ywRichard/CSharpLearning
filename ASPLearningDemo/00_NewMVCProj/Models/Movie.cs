using System;
using System.Data.Entity;

namespace _00_NewMVCProj.Models
{
    /// <summary>
    /// 创建一个Model,先在Model文件中创建类，接着在Controller文件夹中创建一个新的Controller
    /// </summary>
    public class Movie
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext:DbContext//DbContext属于Entity Framework
    {
        public DbSet<Movie> Movies { get; set; }
    }
}