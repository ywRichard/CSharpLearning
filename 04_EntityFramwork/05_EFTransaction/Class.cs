using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _05_EFTransaction
{
    public class Class
    {
        public Class()
        {
            Student = new HashSet<Student>();
        }

        [Key]
        public int ClassId { get; set; }
        public string Teacher { get; set; }
        public string ClassRoom { get; set; }
        public string CourseName { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}