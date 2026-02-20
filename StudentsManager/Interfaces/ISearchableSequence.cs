using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    public interface ISearchableSequence<T>
    {
        int FindIndex(T item);
        int FindIndex(Predicate<T> predicate);
        bool Contains(T item);
    }
}
