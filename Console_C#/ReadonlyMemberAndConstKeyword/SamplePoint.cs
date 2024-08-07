using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyMemberAndConstKeyword
{
    internal class SamplePoint
    {
        public int x;
        //Initialize a readonly field
        public readonly int y=25;
        public readonly int z;
        //Initialize a const field
        public const int t = 100;
        public SamplePoint()
        {
            z = 24;
        }
        public SamplePoint(int p1,int p2,int p3,int p4 = 50)
        {
            x= p1;
            y= p2;
            z= p3;
            //t=p4;//error
        }
    }
}
