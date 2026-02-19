using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList_Test
{
    public interface IDynamicSequence<T>
    {
        void InsertAt(int index, T item);
        void DeleteAt(int index);
        void InsertFirst(T item);
        void DeleteFirst();
        void InsertLast(T item);
        void DeleteLast();
    }
}
