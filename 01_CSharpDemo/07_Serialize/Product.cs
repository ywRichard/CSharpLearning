using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Serialize
{
    [Serializable]
    class Product
    {
        public long _id;
        public string _name;
        public double _price;

        [NonSerialized]
        string _notes;

        public Product(long id, string name, double price, string notes)
        {
            _id = id;
            _name = name;
            _price = price;
            _notes = notes;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} (${2:F2}) {3}", _id, _name, _price, _notes);
        }
    }
}
