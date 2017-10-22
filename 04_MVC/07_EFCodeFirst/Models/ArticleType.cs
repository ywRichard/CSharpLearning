using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _07_EFCodeFirst.Models
{
    public class ArticleType
    {
        public ArticleType()
        {
            ArticleInfo = new HashSet<ArticleInfo>();
        }

        [Key]
        public int TypeId { get; set; }
        public string TypeTitle { get; set; }

        public virtual ICollection<ArticleInfo> ArticleInfo { get; set; }
    }
}