using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class ArrayList
    {
        public int Length { get; private set; }
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
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = new int[10];
            _array = value;
        }


        public int GetLength()
        {
            return Length;
        }

        public int[] ToArray()
        {
            int[] tmp = new int[Length];
            tmp = _array;
            return tmp;
        }


        public void UpSize()
        {
            int newLength;
            newLength = (_array.Length * 3 / 2);
            int[] tmparray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmparray[i] = _array[i];
            }
            _array = tmparray;
        }

        public void AddFirst(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            int[] tmparray = _array;

            for (int i = 0; i < _array.Length; i++)
            {
                tmparray[i + 1] = _array[i];
                _array[i] = tmparray[i + 1];
            }

            _array[0] = value;
            Length++;
        }

        ArrayList list = new ArrayList(new int[] { 0, 1, 2, 3 });        

        public void AddFirst(ArrayList list)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

        }


        public void AddLast(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

       

        public void AddAt(int idx, int val)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            Length++;

            int[] tmparray = _array;
            for (int i = idx; i < Length  ; i ++)
            {
                tmparray[i + 1] = _array[i];
                _array[i] = tmparray[i + 1];
            }

            _array[idx] = val;
        }

        public void Set(int idx, int val)
        {
            _array[idx] = val;
        }

        private void DownSize()
        {
            if (Length < (_array.Length / 2 - 1))
            {
                int newLength = _array.Length / 3;
                int[] tmpArray = new int[newLength];

                for (int i = 0; i < newLength; i++)
                {
                    tmpArray[i] = _array[i];
                }

                _array = tmpArray;

                DownSize();
            }
        }

        public void RemoveFirst()
        {
            int[] tmpArray = _array;
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i + 1];
                _array[i] = tmpArray[i]; 
            }
            Length--;
            UpSize();
        }

        public void RemoveLast()
        {
            _array[Length] = 0;
            DownSize();
        }

        






    }
}
