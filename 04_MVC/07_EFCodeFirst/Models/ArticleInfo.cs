using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _07_EFCodeFirst.Models
{
    public class ArticleInfo
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public int TypeId { get; set; }

        public virtual ArticleType ArticleType { get; set; }
    }
}