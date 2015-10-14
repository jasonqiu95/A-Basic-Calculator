using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class MyInt
    {
        int n;

        public MyInt()
        {
            n = 0;
        }

        public bool equal(int m)
        {
            if (n == m)
                return true;
            else return false;
        }

        public void add()
        {
            n++;
        }
    }
}
