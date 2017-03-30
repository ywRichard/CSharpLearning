using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace _00_NewMVCProj.Models
{
    /// <summary>
    /// 创建一个Model,先在Model文件中创建类，接着在Controller文件夹中创建一个新的Controller
    /// </summary>
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength=3)]//设置验证title字符长度
        public string title { get; set; }

        //Attribute
        [Display(Name="上映日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]//Genre的命名规则
        [Required]//必须设置的参数
        [StringLength(30)]//字符长度上限
        public string Genre { get; set; }

        [Range(1,100)]//价格范围
        [DataType(DataType.Currency)]//数据类型---现金类
        public decimal Price { get; set; }
    }

    public class MovieDBContext:DbContext//DbContext属于Entity Framework
    {
        public DbSet<Movie> Movies { get; set; }
    }
}