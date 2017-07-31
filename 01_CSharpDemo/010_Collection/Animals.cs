using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Collection
{
    public class Animals : CollectionBase
    {
        public Animals()
        {

        }
        /// <summary>
        /// 索引器的语法
        /// </summary>
        public Animal this[int index]
        {
            get { return (Animal)List[index]; }
            set { List[index] = value; }
        }

        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }
    }
}
