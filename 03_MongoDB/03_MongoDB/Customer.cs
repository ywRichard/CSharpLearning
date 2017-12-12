using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MongoDB
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public int CusId { get; set; }
        public DateTime SubTime { get; set; }
        public List<Order> Orders { get; set; }
        public string Demo { get; set; }
        public string Datetime { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string Content { get; set; }
    }
}
