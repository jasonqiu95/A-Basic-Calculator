using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class OpNode : EquationNode
    {
        private int op;//0 -> +, 1 -> -, 2 -> *, 3 -> /

        public OpNode(int n)
        {
            op = n;
        }

        public override bool isEqual(EquationNode node)
        {
            if (node is OpNode)
            {
                if (op == ((OpNode)node).op)
                {
                    if (op == 0 || op == 2)
                    {
                        if ((leftNode.isEqual(node.leftNode) && rightNode.isEqual(node.rightNode)) || (leftNode.isEqual(node.rightNode) && rightNode.isEqual(node.leftNode)))
                            return true;
                    }
                    else
                    {
                        if (leftNode.isEqual(node.leftNode) && rightNode.isEqual(node.rightNode))
                            return true;
                    }
                }
            }
            return false;    
        }

        public override Num compute(bool haveNegative)
        {
            if (op == 0)//+
            {
                Num r1 = leftNode.compute(haveNegative);
                Num r2 = rightNode.compute(haveNegative);
                if (r1 == null || r2 == null)
                    return null;
                else
                {
                    Num re = r1.add(r2, haveNegative);
                    return re;
                }
            }
            else if (op == 1)//-
            {
                Num r1 = leftNode.compute(haveNegative);
                Num r2 = rightNode.compute(haveNegative);
                if (r1 == null || r2 == null)
                    return null;
                else
                {
                    Num re = r1.sub(r2, haveNegative);
                    return re;
                }
            }
            else if (op == 2)//*
            {
                Num r1 = leftNode.compute(haveNegative);
                Num r2 = rightNode.compute(haveNegative);
                if (r1 == null || r2 == null)
                    return null;
                else
                {
                    Num re = r1.multi(r2, haveNegative);
                    return re;
                }
            }
            else// /
            {
                Num r1 = leftNode.compute(haveNegative);
                Num r2 = rightNode.compute(haveNegative);
                if (r1 == null || r2 == null)
                    return null;
                else
                {
                    Num re = r1.div(r2, haveNegative);
                    return re;
                }
            }
        }

        public override string toString()//符号周围有空格！！！
        {
            string re = "( ";
            re += leftNode.toString();
            if (op == 0)
                re += " + ";
            else if (op == 1)
                re += " - ";
            else if (op == 2)
                re += " × ";
            else
                re += " ÷ ";
            re = re + rightNode.toString() + " )";
            return re;
        }

        public override string ToString()
        {
            string re = "(";
            re += leftNode.ToString();
            if (op == 0)
                re += "+";
            else if (op == 1)
                re += "-";
            else if (op == 2)
                re += "×";
            else
                re += "÷";
            re = re + rightNode.ToString() + ")";
            return re;
        }

        public int getOp()
        {
            return op;
        }
    }
}
