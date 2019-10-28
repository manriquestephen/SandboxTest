using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SandboxTest.Test
{
    public class BaseEnumerable : IEnumerable<object[]>
    {
        List<object[]> list = new List<object[]>();

       

        protected void AddToList(object[] obj)
        {
            list.Add(obj);
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    public class TriEnumerable<T1,T2,T3> : BaseEnumerable
    {
        protected void Add(T1 t, T2 t2, T3 t3)
        {
            base.AddToList(new object[] { t, t2, t3 });
        }
    }

    public class MultiplicationEnumerable : TriEnumerable<int, int, int>
    {
        public MultiplicationEnumerable()
        {
            base.Add(1, 2, 2);
            base.Add(2, 2, 4);
            base.Add(3, 2, 6);
        }
    };
}

