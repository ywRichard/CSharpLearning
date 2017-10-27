using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EFConcurrency
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [ConcurrencyCheck]//并发检查
        public string Description { get; set; }
        [Timestamp]//唯一标识符->标识整条记录的特殊字段，由数据库维护
        public byte[] RowVersion { get; set; }

    }
}
