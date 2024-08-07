using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class MyCollection<T> : IEnumerable where T : class, new()
    {
        private List<T> myList = new List<T>();

        public void AddItem(params T[] items) => myList.AddRange(items);

        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }
}
