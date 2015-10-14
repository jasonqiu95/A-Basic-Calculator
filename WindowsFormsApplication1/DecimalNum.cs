using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class DecimalNum : Num
    {
        int integer;
        int numerator;//分子
        int denominator;//分母

        //带分数转化成假分数
        private void convertToIm()
        {
            numerator = numerator + integer * denominator;
            integer = 0;
        }

        //假分数转化成带分数
        public void convertToMix()
        {
            int x = numerator / denominator;
            integer = integer + x;
            numerator = numerator - x * denominator;
            if (numerator == 0)
                denominator = 1;
        }

        //传递的参数必须是合法的，在调用完构造函数会马上调用repOK
        public DecimalNum(int n1, int n2, int n3, int plus) : base(plus)
        {
            integer = n1;
            numerator = n2;
            denominator = n3;
            convertToIm();
        }

        public override bool isEqual(Num num)
        {
            if (num is DecimalNum)
            {
                if (numerator == ((DecimalNum)num).numerator && numerator == 0 && integer == ((DecimalNum)num).integer)
                    return base.isEqual(num);
                else if (numerator == ((DecimalNum)num).numerator && denominator == ((DecimalNum)num).denominator && integer == ((DecimalNum)num).integer)
                    return base.isEqual(num);
                else return false;
            }
            else return false;
        }

        //调用函数之前检查b是否为零
        private int gcd(int a, int b)
        {
            int t;
            /************************/
            if (a == 0 || b == 0)
                return 1;
            /***********************/
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }
            while ((t = a % b) > 0)
            {
                a = b;
                b = t;
            }
            return b;
        }

        private int lcm(int a, int b)
        {
            int t = gcd(a, b);
            int x = a / t;
            int y = b / t;
            return t * x * y;
        }

        //计算时保证是假分数！！！！！！！！！！！！！！
        public override Num add(Num num, bool haveNegative)
        {
            if (num is DecimalNum)
            {
                int n = lcm(denominator, ((DecimalNum)num).denominator);
                int n1 = n / denominator;
                int n2 = n / ((DecimalNum)num).denominator;
                int newn;
                if (isPlus == 2 && num.isPlus == 2) // -a + -b
                    newn = 0 - n1 * numerator - n2 * ((DecimalNum)num).numerator;
                else if (isPlus == 1 && num.isPlus == 2) // a + -b
                    newn = n1 * numerator - n2 * ((DecimalNum)num).numerator;
                else if (isPlus == 2 && num.isPlus == 1) // -a + b
                    newn = n2 * ((DecimalNum)num).numerator - n1 * numerator;
                else
                    newn = n1 * numerator + n2 * ((DecimalNum)num).numerator;
                if (!haveNegative)
                    return new DecimalNum(0, newn / gcd(newn, n), n / gcd(newn, n), 0);
                else
                {
                    if (newn >= 0)
                        return new DecimalNum(0, newn / gcd(newn, n), n / gcd(newn, n), 1);
                    else return new DecimalNum(0, 0 - newn / gcd(newn, n), n / gcd(newn, n), 2);
                }
            }
            else return null;
        }

        public override Num sub(Num num, bool haveNegative)
        {
            if (num is DecimalNum)
            {
                int n = lcm(denominator, ((DecimalNum)num).denominator);
                int n1 = n / denominator;
                int n2 = n / ((DecimalNum)num).denominator;
                int newn;
                if (isPlus == 2 && num.isPlus == 2) // -a - -b
                    newn = n2 * ((DecimalNum)num).numerator - n1 * numerator;
                else if (isPlus == 1 && num.isPlus == 2) // a - -b
                    newn = n1 * numerator + n2 * ((DecimalNum)num).numerator;
                else if (isPlus == 2 && num.isPlus == 1) // -a - b
                    newn = 0 - n2 * ((DecimalNum)num).numerator - n1 * numerator;
                else//a - b
                    newn = n1 * numerator - n2 * ((DecimalNum)num).numerator;
                if (!haveNegative)
                {
                    if (newn < 0)
                        return null;
                    return new DecimalNum(0, newn / gcd(newn, n), n / gcd(newn, n), 0);
                }
                else
                {
                    if (newn >= 0)
                        return new DecimalNum(0, newn / gcd(newn, n), n / gcd(newn, n), 1);
                    else return new DecimalNum(0, 0 - newn / gcd(newn, n), n / gcd(newn, n), 2);
                }
            }
            else return null;
        }

        public override Num multi(Num num, bool haveNegative)
        {
            if (num is DecimalNum)
            {
                int new1 = numerator * ((DecimalNum)num).numerator;
                int new2 = denominator * ((DecimalNum)num).denominator;
                int n = gcd(new1, new2);
                if (!haveNegative)
                    return new DecimalNum(0, new1 / n, new2 / n, 0);
                else
                {
                    if (((isPlus == 2 && num.isPlus == 1) || (isPlus == 1 && num.isPlus == 2)) && new1 != 0)
                        return new DecimalNum(0, new1 / n, new2 / n, 2);
                    else return new DecimalNum(0, new1 / n, new2 / n, 1);
                }
            }
            else return null;
        }

        public override Num div(Num num, bool haveNegative)
        {
            if (num is DecimalNum)
            {
                if (((DecimalNum)num).numerator == 0)
                    return null;

                int new1 = numerator * ((DecimalNum)num).denominator;
                int new2 = denominator * ((DecimalNum)num).numerator;
                int n = gcd(new1, new2);
                if (!haveNegative)
                    return new DecimalNum(0, new1 / n, new2 / n, 0);
                else
                {
                    if (((isPlus == 2 && num.isPlus == 1) || (isPlus == 1 && num.isPlus == 2)) && new1 != 0)
                        return new DecimalNum(0, new1 / n, new2 / n, 2);
                    else return new DecimalNum(0, new1 / n, new2 / n, 1);
                }
            }
            else return null;
        }

        public override string toString()
        {
            convertToMix();
            string re = "";
            if (isPlus == 2)
                re = re + "-";
            if (numerator == 0)
            {
                re = re + integer;
                return re;
            }
            if (integer == 0)
            {
                re = re + numerator + "/" + denominator;
                return re;
            }
            else
            {
                re = re + integer + "'" + numerator + "/" + denominator;
                return re;
            }
        }

        public override string ToString()
        {
            string re = "";
            if (isPlus == 2)
                re = re + "-";
            if (numerator == 0)
            {
                re = re + integer;
                return re;
            }
            else
            {
                re = re + integer + "'" + numerator + "/" + denominator;
                return re;
            }
        }
    }
}
