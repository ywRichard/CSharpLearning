//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _07_MvcOA.Model
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublisherId { get; set; }
        public System.DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int WordsCount { get; set; }
        public decimal UnitPrice { get; set; }
        public string ContentDescription { get; set; }
        public string AuthorDescription { get; set; }
        public string EditorComment { get; set; }
        public string TOC { get; set; }
        public short Category { get; set; }
        public int CategoryId { get; set; }
        public int Clicks { get; set; }
    }
}
