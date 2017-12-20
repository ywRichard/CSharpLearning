using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    /// <summary>
    /// C#1中手动实现的迭代器简化模型
    /// </summary>
    public class IterationSample : IEnumerable
    {
        private object[] _values;
        private int _startingPoint;

        public IterationSample(object[] values, int startingPoint)
        {
            _values = values;
            _startingPoint = startingPoint;
        }
        public IEnumerator GetEnumerator()
        {
            return new IterationSampleIterator(this);
        }
        /// <summary>
        /// 嵌套类可以访问它外层类型的私有成员
        /// </summary>
        class IterationSampleIterator : IEnumerator
        {
            private readonly IterationSample _parent;
            private int _position;

            internal IterationSampleIterator(IterationSample parent)
            {
                _parent = parent;
                _position = -1;
            }

            public bool MoveNext()
            {
                if (_position != _parent._values.Length)
                {
                    _position++;
                }

                return _position < _parent._values.Length;
            }

            public void Reset()
            {
                _position = -1;
            }

            public object Current
            {
                get
                {
                    if (_position == -1 || _position == _parent._values.Length)
                    {

                    }
                    var index = _position + _parent._startingPoint;
                    index = index % _parent._values.Length;
                    return _parent._values[index];
                }
            }
        }
    }
}
