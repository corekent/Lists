using System;

namespace ArrayList
{
    public class ArrayList
    {
        public int Length;
        private int[] _array;

        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }
        public ArrayList(int[] array)
        {
            
            Length = array.Length;
            _array = array;
        }

        public int GetLength()
        {
            return Length;
        }
        public int[] ToArray()
        {
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                array[i] = _array[i];
            }
            return array;
        }

        public void Upsize()
        {
            int newLength = _array.Length * 3 / 2 + 1;
            int[] tmpArr = new int[newLength];
            for (int i = 0; i < Length; i++)
            {
                tmpArr[i] = _array[i];
            }
            _array = tmpArr;
        }
        public void DownSize()
        {
            int newLength = Length * 2 / 3;
            int[] tmpArr = new int[newLength];
            for (int i = 0; i < newLength; i++)
            {
                tmpArr[i] = _array[i];
            }
            _array = tmpArr;
        }

        public void CheckUpSize()
        {
            if (Length == _array.Length)
            {
                Upsize();
            }
        }
        public void CheckDownSize()
        {
            if (Length > _array.Length * 0.5)
            {
                DownSize();
            }
        }

        public void AddFirst(int value)
        {
            CheckUpSize();
            for (int i = Length; i > 0; i--)
            {                
                _array[i] = _array[i - 1];
            }
            _array[0] = value; 
            Length++;            
        }
        public void AddFirst(ArrayList array)
        {
            int[] tmpArray = new int[Length + array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tmpArray[i] = array._array[i];
            }
            for (int i = array.Length; i < tmpArray.Length; i++)
            {
                tmpArray[i] = _array[i - array.Length];
            }                        
            if (tmpArray.Length >= _array.Length)
            {
                Upsize();
            }
            _array = tmpArray;
            Length += array.Length;
        }
        public int[] AddLast(int value)
        {
            CheckUpSize();
            for (int i = 0; i < Length; i++)
            {
                int tmp = _array[i + 1];
                _array[i] = tmp;
            }
            _array[Length] = value;
            Length++;
            return _array;
        }
        public void AddLast(ArrayList list)
        {

        }

        public int[] AddAt(int idx, int value)
        {
            CheckUpSize();
            if(idx == 0)
            {
                AddFirst(value);
            }
            else if(idx == Length)
            {
                AddLast(value);
            }
            else
            {
                for (int i = idx; i < Length; i++)
                {
                    _array[i + 1] = _array[i];
                }
                _array[idx] = value;
            }
            return _array;
        }
    }
}
