using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    public interface IContainer<T>
    {
        void Build(IEnumerable<T> items);
        void Clear();
        int GetLength();
        bool IsEmpty();
    }
}
