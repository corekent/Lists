using System;

namespace ArrayList
{
    public class ArrayList : InterfaceForList
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
            if(_array.Length > 10)
            {
                if(Length < _array.Length * 0.5)
                {
                 DownSize();
                }
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

        public void AddLast(int value)
        {
            CheckUpSize();            
            _array[Length] = value;
            Length++;            
        }
        public void AddLast(ArrayList array)
        {
            int newLength = Length + array.Length;

            while (newLength >= _array.Length)
            {
                Upsize();
            }
            for (int i = Length; i < newLength; i++)
            {
                _array[i] = array._array[i - Length];
            }

            Length = newLength;
        }

        public void AddAt(int idx, int value)
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
            else if(idx < 0 || idx > Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Length++;
                for (int i = idx; i < Length; i++)
                {
                    _array[i + 1] = _array[i];
                }
                _array[idx] = value;
            }            
        }
        public void AddAt(ArrayList array, int idx)
        {

        }

        public void Set(int idx, int value)
        {
            if (idx < 0 || idx > Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                _array[idx] = value;
            }
        }
        public void RemoveFirst()
        {                       
            for (int i = 1; i < _array.Length; i++)
            {
             _array[i - 1] = _array[i];
            }
            
            Length--;
            CheckDownSize();
        }
        public void RemoveLast()
        {
            Length--;
            CheckDownSize();
        }
        public void RemoveAt(int idx)
        {
            Length--;
            for (int i = idx + 1; i < _array.Length; i++)
            {
                _array[i - 1] = _array[i];
            }
            CheckDownSize();
        }
        public void RemoveFirstMultiple(int n)
        {
            for(int i = 0; i < n; i++)
            {
                RemoveFirst();
            }     
        }
        public void RemoveLastMultiple(int n)
        {
            Length -= n;
            CheckDownSize();
        }
        public void RemoveAtMultiple(int idx, int n)
        {
            for (int i = 0; i < n; i++)
            {
                RemoveAt(idx);
            }
            CheckDownSize();
        }
        public int RemoveAll(int val)
        {
            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {
                    RemoveAt(i);
                    count++;
                    
                }
            }
            return count;
        }

        public string Contains(int val)
        {
            for (int i = 0; i < Length; i++)
            {
                if (val == _array[i])
                {
                    return "yes";
                }
            }
            return "no";
        }
        public int IndexOf(int val)
        {
            for (int i = 0; i < Length; i++)
            {
                if (val == _array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetFirst()
        {
            return _array[0];
        }
        public int GetLast()
        {
            return _array[Length - 1];
        }
        public int Get(int idx)
        {          
            return _array[idx];
        }
        public void Reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }
        public int FindMaxElement()
        {
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int FindMinElement()
        {
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int IndexOfMax()
        {
            int indexOfMax = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[indexOfMax] < _array[i])
                {
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }

        public int IndexOfMin()
        {
            int min = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[min] > _array[i])
                {
                    min = i;
                }
            }
            return min;
        }

        public void Sort()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                int min = i;

                for (int j = i; j < Length; j++)
                {
                    if (_array[min] > _array[j])
                    {
                        min = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[min];
                _array[min] = tmp;
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < Length - 1 ; i++)
            {
                int max = i;

                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[max] < _array[j])
                    {
                        max = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[max];
                _array[max] = tmp;
            }
        }

    }
}
