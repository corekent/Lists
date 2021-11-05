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
        public LinkedList(int[] values)
        {
            if(values.Length != 0)
            {
                
                _head = new Node(values[0]);
                _tail = _head;

                for(int i = 1; i < values.Length; i++)
                {
                    AddLast(values[i]);
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
            _head.Next = _head;
            _head = new Node(val);
        }
        public void AddLast(int val)
        {
            _tail.Next = new Node(val);
            _tail = _tail.Next;
        }


    }
}



