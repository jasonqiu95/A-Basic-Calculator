using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Calculator
    {
        Stack<string> opStack = new Stack<string>();
        Stack<Num> numStack = new Stack<Num>();

        private int getOpValue(string op)
        {
            if (op == "+" || op == "-")
                return 1;
            else if (op == "(")
                return 0;
            else
                return 2;
        }

        //op1优先级大于op2才返回true!!!!!!!!!!!!
        private bool compareOp(string op1, string op2)
        {
            if (getOpValue(op1) > getOpValue(op2))
                return true;
            else return false;
        }

        private Num compute(Num n1, Num n2, string op)
        {
            if (op == "+")
                return n1.add(n2, true);
            else if (op == "-")
                return n1.sub(n2, true);
            else if (op == "×")
                return n1.multi(n2, true);
            else
                return n1.div(n2, true);
        }

        private DecimalNum getDecimalNum(string s)
        {
            int plus;
            if (s[0] == '-')
            {
                plus = 2;
                s = s.Substring(1, s.Length - 1);
            }
            else plus = 1;

            int p1 = s.IndexOf('\'');
            int p2 = s.IndexOf('/');
            if (p1 != -1)
            {
                int integer = int.Parse(s.Substring(0, p1));
                int numerator = int.Parse(s.Substring(p1 + 1, p2 - p1 - 1));
                int denomitor = int.Parse(s.Substring(p2 + 1, s.Length - p2 - 1));
                if (denomitor == 0)
                    return null;
                DecimalNum re = new DecimalNum(integer, numerator, denomitor, plus);
                return re;
            }
            else if (p2 != -1)
            {
                int numerator = int.Parse(s.Substring(0, p2));
                int denomitor = int.Parse(s.Substring(p2 + 1, s.Length - p2 - 1));
                if (denomitor == 0)
                    return null;
                DecimalNum re = new DecimalNum(0, numerator, denomitor, plus);
                return re;
            }
            else
            {
                int integer = int.Parse(s);
                DecimalNum re = new DecimalNum(integer, 0, 1, plus);
                return re;
            }
        }

        public bool parse(string s)
        {
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word == "(")
                    opStack.Push(word);
                else if (word == "+" || word == "-" || word == "×" || word == "÷")
                {
                    if (opStack.Count() == 0)
                        opStack.Push(word);
                    else
                    {
                        if (compareOp(word, opStack.Peek()))
                            opStack.Push(word);
                        else
                        {
                            Num num2 = numStack.Pop();
                            Num num1 = numStack.Pop();
                            Num re = compute(num1, num2, opStack.Pop());
                            if (re == null)//如果无法计算！！！！！！！！！！！！！！！！
                                return false;
                            numStack.Push(re);
                        }
                    }
                }
                else if (word == ")")
                {
                    while (opStack.Peek() != "(")
                    {
                        Num num2 = numStack.Pop();
                        Num num1 = numStack.Pop();
                        numStack.Push(compute(num1, num2, opStack.Pop()));
                    }
                    opStack.Pop();
                }
                else
                {
                    DecimalNum newN = getDecimalNum(word);
                    if (newN == null)
                        return false;
                    numStack.Push(newN);
                }
            }
            return true;
        }

        public Num calculate(string s)
        {
            opStack.Clear();
            numStack.Clear();

            if (!parse(s))
                return null;

            while (opStack.Count() != 0)
            {
                Num num2 = numStack.Pop();
                Num num1 = numStack.Pop();
                Num re = compute(num1, num2, opStack.Pop());
                if (re == null)//如果无法计算！！！！！！！！！！！！！！！！
                    return null;
                numStack.Push(re);
            }

            Num answer = numStack.Pop();
            ((DecimalNum)answer).convertToMix();
            return answer;
        }


    }
}
