using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexingArrays
{
    internal class IndexArrays<T>
    {
        private int _min;
        private int _max;
        private T[] _array;
        public IndexArrays(int min, int max) 
        {
            _min = min;
            _max = max;
            _array = new T[_max - _min];
        }
        public int GetMin()
        {
            return _min;
        }
        public int GetMax() 
        {
            return _max;   
        }
        public int Length()
        {
            return _max;
        }        
        public T this[int index]
        {
            get
            {
                if(index >= _min && index < _max)
                {
                    return _array[index - _min];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                if (index >= _min && index < _max)
                {
                    _array[index - _min] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
