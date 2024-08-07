using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueOfPerformance
{
    public class IntCollection
    {
        private ArrayList arInts = new ArrayList();
        //Get an int (Perform unboxing)!
        internal int GetInt(int pos) => (int)arInts[pos];
        //Insert an int (perform boxing)!
        public void AddInt(int n) => arInts.Add(n);
        public void ClearInts() => arInts.Clear();

        public int Count => arInts.Count;
    }
}
