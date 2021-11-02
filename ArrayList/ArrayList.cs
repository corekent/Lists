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
            int newLength = Length * 2 / 3 + 1;
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

        public int[] AddFirst(int value)
        {
            CheckUpSize();
            Length++;

            for (int i = 1; i < Length; i++)
            {
                int tmp = _array[i - 1];
                _array[i] = tmp;
            }
            _array[0] = value;
            return _array;
        }
        public void AddFirst(ArrayList list)
        {

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
