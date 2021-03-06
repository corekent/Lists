using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }

    public class DoublyLinkedList
    {
        private Node _head;
        private Node _tail;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
        }
        public DoublyLinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }
        public DoublyLinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _head = new Node(array[0]);
                _tail = _head;

                for (int i = 1; i < array.Length; i++)
                {
                    AddLast(array[i]);
                }
            }
            else
            {
                _head = null;
                _tail = null;
            }            
        }
        public int this[int index]
        {
            get
            {
                Node current = _head;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _head;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                current.Value = value;
            }
        }

        public int GetLength()
        {
            int summ = 0;
            Node current = _head;
            while (current != null)
            {
                summ++;
                current = current.Next;
            }
            return summ;
        }
        public int[] ToArray()
        {
            int length = GetLength();
            int[] array = new int[length];
            Node current = _head;
            for (int i = 0; i < length; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }
            return array;
        }

        public void AddFirst(int val)
        {
            if (GetLength() == 0)
            {
                _head = new Node(val);
            }
            else
            {
                _head.Prev = new Node(val);
                _head.Prev.Next = _head;
                _head = _head.Prev;
            }                      
        }
        public void AddFirst(DoublyLinkedList list)
        {
            list._tail.Next = _head;
            _head = list._head;
        }
        public void AddLast(int val)
        {
            if (GetLength() == 0)
            {
                _head = new Node(val);
            }
            else
            {
                _tail.Next = new Node(val);
                _tail = _tail.Next;
            }
        }
        public void AddLast(DoublyLinkedList list)
        {
            for (int i = 0; i < list.GetLength(); i++)
            {
                AddLast(list[i]);
            }
        }
        public void AddAt(int idx, int val)
        {
            if (idx == 0)
            {
                AddFirst(val);
            }
            else if (idx == GetLength())
            {
                AddLast(val);
            }
            else
            {
                Node current = _head;
                for (int i = 1; i < idx; i++)
                {
                    current = current.Next;
                }
                Node tmp = current.Next;
                current.Next = new Node(val);
                current.Next.Next = tmp;
            }
        }
        public void AddAt(int idx, DoublyLinkedList list)
        {
            if (idx == 0)
            {
                AddFirst(list);
            }
            else if (idx == GetLength())
            {
                AddLast(list);
            }
            else
            {
                for (int i = 0; i < list.GetLength(); i++)
                {
                    AddAt(i + idx, list[i]);
                }
            }
        }
        public void Set(int idx, int val)
        {
            Node current = _head;
            Node node = new Node(val);
            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            Node tmp = current.Next.Next;            
            current.Next = node;
            node.Next = tmp;
        }
        public void RemoveFirst()
        {
            _head = _head.Next;
        }
        public void RemoveLast()
        {
            Node current = _head;
            if(GetLength() == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }            
        }
        public void RemoveAt(int idx)
        {
            int length = GetLength();
            if (length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (length == 1)
            {
                _head = null;
                _tail = null;
            }
            else if (idx == 0)
            {
                RemoveFirst();
            }
            else if (idx == length - 1)
            {
                RemoveLast();
            }
            else if (idx <= length / 2)
            {
                Node current = _head;
                for (int i = 1; i < idx; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                current.Next.Prev = current;
            }
            else
            {
                Node current = _tail;
                for (int i = length - 2; i > idx; i--)
                {
                    current = current.Prev;
                }
                current.Prev = current.Prev.Prev;
                current.Prev.Next = current;             
            }
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
            for (int i = 0; i < n; i++)
            {
                RemoveLast();
            }
        }
        public void RemoveAtMultiple(int idx, int n)
        {
            int length = GetLength();
            if (length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (length == 1)
            {
                _head = null;
                _tail = null;
            }
            else if (idx <= length / 2)
            {
                Node current = _head;
                for (int i = 1; i < idx; i++)
                {
                    current = current.Next;
                }
                Node tmp = current;
                for (int i = 0; i < n; i++)
                {
                    current = current.Next;
                }
                tmp.Next = current.Next;
                current.Prev = tmp;
            }
            else
            {
                Node current = _tail;
                for (int i = length - 1; i >= idx; i--)
                {
                    current = current.Prev;
                }
                Node tmp = current;
                for (int i = 0; i < n; i++)
                {
                    current = current.Next;
                }
                tmp.Next = current.Next;
                current.Prev = tmp;
            }
        }
        public int RemoveFirst(int val)
        {
            int idx = IndexOf(val);
            RemoveAt(idx);
            return idx;
        }
        public int RemoveAll(int val)
        {            
            int count = 0;
            int idx = IndexOf(val);
            while(idx != -1)
            {
                RemoveAt(idx);
                count++;
                idx = IndexOf(val);
            }
            return count;
        }
        public string Contains(int val)
        {            
            Node current = _head;
            int length = GetLength();
            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    return "yes";
                }
                current = current.Next;
            }
            return "no";
        }
        public int IndexOf(int val)
        {
            Node current = _head;
            int length = GetLength();
            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }
        public int GetFirst()
        {
            return _head.Value;
        }
        public int GetLast()
        {
            return _tail.Value;
        }
        public int Get(int idx)
        {
            Node current = _head;
            for (int i = 0; i < idx; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        public void Reverse()
        {
            Node current = _head;
            while (current.Next != null)
            {
                //Node tmp = current;
                //current.Prev = _tail;
                //current.Prev.Next = current;
                Node tmp = current.Next;
                current.Next = tmp.Next;
                tmp.Next = _head;
                _head = tmp;
            }
            _tail = current;
        }
        public int Max()
        {
            Node current = _head;
            int max = current.Value;
            while (current != null)
            {
                if (current.Value > max)
                {
                    max = current.Value;
                }
                current = current.Next;
            }            
            return max;
        }
        public int Min()
        {
            Node current = _head;
            int min = _head.Value;
            while (current != null)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                }
                current = current.Next;
            }
            return min;
        }
        public int IndexOfMax()
        {
            return IndexOf(Max());
        }
        public int IndexOfMin()
        {
            return IndexOf(Min());
        }

        //Надеюсь когда-нибудь я узнаю как работает магия сортировок :(

        public void Sort()
        {
            int length = GetLength();
            int max;
            int idx;
            DoublyLinkedList tmp = new DoublyLinkedList();
            while (length != 0)
            {
                max = Max();
                idx = IndexOf(max);
                tmp.AddFirst(max);
                RemoveAt(idx);
            }
            _head = tmp._head;
        }
        public void SortDesc()
        {
            int length = GetLength();
            int min;
            int idx;
            DoublyLinkedList tmp = new DoublyLinkedList();
            while (length != 0)
            {
                min = Min();
                idx = IndexOf(min);
                tmp.AddFirst(min);
                RemoveAt(idx);
            }
            _head = tmp._head;
        }
    }
}
