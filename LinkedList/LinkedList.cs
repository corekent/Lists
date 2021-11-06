using System;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {        
        private Node _head;
        private Node _tail;

        public LinkedList()
        {
            _head = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }
        public LinkedList(int[] array)
        {
            if(array.Length != 0)
            {                
                _head = new Node(array[0]);
                _tail = _head;

                for(int i = 1; i < array.Length; i++)
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
            for(int i = 0; i < length; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }
            return array;
        }
        public void AddFirst(int val)
        {
            Node current = _head;
            _head = new Node(val);
            _head.Next = current;
            //Node node = new Node(val);
            //node.Next = _head;
            //_head = node;
        }

        public void AddFirst(LinkedList list)
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
        public void AddLast(LinkedList list)
        {                        
            for (int i = 0; i < list.GetLength(); i++)
            {
                AddLast(list[i]);
            }
        }

        public void AddAt(int idx, int val)
        {      
            if(idx == 0)
            {
                AddFirst(val);
            }
            else if(idx == GetLength())
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
        public void AddAt(int idx, LinkedList list)
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
                for(int i = 0; i < list.GetLength(); i++)
                {
                    AddAt(i + idx, list[i]);
                }
            }
        }
        public void Set(int idx, int val)
        {            
            Node current = _head;
            for(int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            Node tmp = current.Next.Next;
            Node node = new Node(val);
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
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }


    }
}



