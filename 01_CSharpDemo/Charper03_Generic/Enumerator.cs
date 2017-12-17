using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper03_Generic
{
    class Enumerator
    {
    }

    public class CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    /// <summary>
    /// 继承了IEnumerator接口后，Runtime会执行枚举器接口的实现。通过MoveNext生成找到所有枚举值
    /// debug调试不到这些信息
    /// </summary>
    public class CountingEnumerator : IEnumerator<int>
    {
        private int current = -1;
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            current++;
            return current < 10;
        }

        public int Current => current;
        public void Reset()
        {
            current = -1;
        }

        object IEnumerator.Current => Current;
    }
}
