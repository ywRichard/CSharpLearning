//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookInfo
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookContent { get; set; }
        public int Tid { get; set; }
    
        public virtual BookType BookType { get; set; }
    }
}
