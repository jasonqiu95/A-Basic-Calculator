using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class IntegerNum : Num
    {
        int integer;
        public IntegerNum(int n, int plus)
            : base(plus)
        {
            integer = n;
        }

        public override bool isEqual(Num num)
        {
            if (base.isEqual(num) && integer == ((IntegerNum)num).integer)
                return true;
            else return false;
        }

        public override Num add(Num num, bool haveNegative)
        {
            if (num is IntegerNum)
            {
                int n;
                if (isPlus == 2 && num.isPlus == 2) //-a + -b
                   n = 0 - integer - ((IntegerNum)num).integer;
                else if (isPlus == 1 && num.isPlus == 2)//a + -b
                    n = integer - ((IntegerNum)num).integer;
                else if (isPlus == 2 && num.isPlus == 1)//-a + b
                    n = ((IntegerNum)num).integer - integer;
                else //a + b
                    n = integer + ((IntegerNum)num).integer;
                if (!haveNegative)
                    return new IntegerNum(n, 0);
                else if (n >= 0)
                    return new IntegerNum(n, 1);
                else return new IntegerNum(0 - n, 2);
            }
            else return null;
        }

        public override Num sub(Num num, bool haveNegative)
        {
            if (num is IntegerNum)
            {
                int n;
                if (isPlus == 2 && num.isPlus == 2) //(-a) - (-b)
                   n = ((IntegerNum)num).integer - integer;
                else if (isPlus == 1 && num.isPlus == 2)//a - (-b)
                    n = integer + ((IntegerNum)num).integer;
                else if (isPlus == 2 && num.isPlus == 1)//-a - b
                    n = 0 - integer - ((IntegerNum)num).integer;
                else//a - b
                    n = integer - ((IntegerNum)num).integer;
                if (!haveNegative) 
                {
                    if(n < 0)//要求不能有负数，但是出现了负数
                        return null;                       
                    return new IntegerNum(n, 0);
                }
                else if (n >= 0)
                    return new IntegerNum(n, 1);
                else return new IntegerNum(0 - n, 2);
            }
            else return null;
        }

        public override Num multi(Num num, bool haveNegative)
        {
            if (num is IntegerNum)
            {
                int n;
                if ((isPlus == 2 && num.isPlus == 1) || (isPlus == 1 && num.isPlus == 2)) //-a * b, a * -b
                    n = 0 - integer * ((IntegerNum)num).integer;
                else //a * b, -a * -b, 还有无符号的情况
                    n = integer * ((IntegerNum)num).integer;
                if (!haveNegative)
                    return new IntegerNum(n, 0);
                else if (n >= 0)
                    return new IntegerNum(n, 1);
                else return new IntegerNum(0 - n, 2);
            }
            else return null;
        }

        public override Num div(Num num, bool haveNegative)
        {
            if (num is IntegerNum)
            {
                int n;
                if (((IntegerNum)num).integer == 0)
                    return null;
                int remainder = integer % ((IntegerNum)num).integer;
                if (remainder != 0)
                    return null;
                if ((isPlus == 2 && num.isPlus == 1) || (isPlus == 1 && num.isPlus == 2)) //-a / b, a / -b
                    n = 0 - integer / ((IntegerNum)num).integer;
                else //a / b, -a / -b, 还有无符号的情况
                    n = integer / ((IntegerNum)num).integer;
                if (!haveNegative)
                    return new IntegerNum(n, 0);
                else if (n >= 0)
                    return new IntegerNum(n, 1);
                else return new IntegerNum(0 - n, 2);
            }
            else return null;
        }

        public override string toString()
        {
            if (isPlus == 2)
                return "-" + integer;
            else
                return "" + integer;
        }

        public override string ToString()
        {
            if (isPlus == 2)
                return "-" + integer;
            else
                return "" + integer;
        }
    }
}
