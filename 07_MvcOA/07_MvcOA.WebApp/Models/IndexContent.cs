using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07_MvcOA.WebApp.Models
{
    public class IndexContent
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Model.LuceneEnum LuceneEnum { get; set; }
    }
}