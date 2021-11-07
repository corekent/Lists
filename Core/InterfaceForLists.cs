using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    interface InterfaceForLists
    {
        int GetLength();
        int[] ToArray();
        void AddFirst(int value);
        void AddLast(int value);
        void AddAt(int idx, int value);
        void Set(int idx, int value);
        void RemoveFirst();
        void RemoveLast();
        void RemoveAt(int idx);
        void RemoveFirstMultiple(int n);
        void RemoveLastMultiple(int n);
        void RemoveAtMultiple(int idx, int n);
        int RemoveAll(int val);
        string Contains(int val);
        int IndexOf(int val);
        int GetFirst();
        void Reverse();
        int FindMaxElement();
        int FindMinElement();
        int IndexOfMax();
        int IndexOfMin();
        void Sort();
        void SortDesc();
    }
}
