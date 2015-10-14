using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    interface CoreInterface
    {
        // interface members
        void setting(int numOfQ, int rangeOfNum, int numOfOp, bool haveMulti, bool haveNegative, bool haveDecimal);
        string calc(string s);
        void generate();
        void grade(String A, String Q);
    }
}
