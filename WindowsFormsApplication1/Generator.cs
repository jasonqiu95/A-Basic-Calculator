using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Generator
    {
        private List<EquationNode> nodes;
        private List<Num> answers;
        private int numOfQ;
        private int rangeOfNum;
        private int numOfOp;
        private bool haveMulti;
        private bool haveNegative;
        private bool haveDecimal;
        private Random ran;

        //生成一个生成器
        //传入的参数顺序是题目个数，数值的范围，题目中运算符的个数，是否有乘除号，题目及运算过程中有无负数，题目及运算过程中有无分数，

        public void setting(int num, int range, int op, bool multi, bool negative, bool isdecimal)
        {
            nodes = new List<EquationNode>();
            answers = new List<Num>();
            numOfQ = num;
            rangeOfNum = range;
            numOfOp = op;
            haveMulti = multi;
            haveNegative = negative;
            haveDecimal = isdecimal;
            ran = new Random();
        }

        //随机生成返回一个OpNode，0 => +, 1 => -, 2 => *, 3 => /
        public EquationNode generateOp()
        {
            if (haveMulti)
            {
                EquationNode node = new OpNode(ran.Next(0, 4));
                return node;
            }
            else
            {
                EquationNode node = new OpNode(ran.Next(0, 2));
                return node;
            }
        }

        //生成一个合法的NumNode
        public EquationNode generateNum()
        {
            if (!haveNegative && !haveDecimal)
            {
                Num m = new IntegerNum(ran.Next(0, rangeOfNum), 0);
                EquationNode node = new NumNode(m);
                return node;
            }
            else if (haveNegative && !haveDecimal)
            {
                int judge = ran.Next(1, 3);
                Num m = new IntegerNum(ran.Next(0, rangeOfNum), judge);
                EquationNode node = new NumNode(m);
                return node;
            }
            else if (!haveNegative && haveDecimal)
            {
                int n1 = ran.Next(0, rangeOfNum);
                int n3 = ran.Next(0, rangeOfNum);
                int n2 = ran.Next(0, n3);
                if (n3 == 0)
                {
                    Num m = new DecimalNum(n1, 0, 1, 0);
                    EquationNode node = new NumNode(m);
                    return node;
                }
                else
                {
                    Num m = new DecimalNum(n1, n2, n3, 0);
                    EquationNode node = new NumNode(m);
                    return node;
                }
                
            }
            else //(haveNegative && haveDecimal)
            {
                int judge = ran.Next(1, 3);
                int n1 = ran.Next(0, rangeOfNum);
                int n3 = ran.Next(0, rangeOfNum);
                if (n3 == 0)
                {
                    Num m = new DecimalNum(n1, 0, 1, judge);
                    EquationNode node = new NumNode(m);
                    return node;
                }
                else
                {
                    int n2 = ran.Next(0, n3);
                    Num m = new DecimalNum(n1, n2, n3, judge);
                    EquationNode node = new NumNode(m);
                    return node;
                }
            }
        }

        //从一个node出发生成一个树这里的node is OpNode，直到这个节点的两个孩子节点都是NumNode，返回
        public void generate(EquationNode node, MyInt n)
        {
            if (n.equal(numOfOp))
            {
                node.setLeft(generateNum());
                node.setRight(generateNum());
                return;
            }
            else
            {
                int judge1 = ran.Next(0, 2);
                if (judge1 == 0)
                {
                    node.setLeft(generateNum());
                    node.setRight(generateNum());
                    return;
                }
                else
                {
                    int judge2 = ran.Next(0, 3);
                    if (judge2 == 0)
                    {
                        node.setLeft(generateNum());
                        EquationNode node1 = generateOp();
                        n.add();
                        generate(node1, n);
                        node.setRight(node1);
                    }
                    else if(judge2 == 1)
                    {
                        node.setRight(generateNum());
                        EquationNode node1 = generateOp();
                        n.add();
                        generate(node1, n);
                        node.setLeft(node1);
                    }
                    else
                    {
                        EquationNode node1 = generateOp();
                        n.add();
                        generate(node1, n);
                        node.setRight(node1);
                        if (n.equal(numOfOp))
                        {
                            node.setLeft(generateNum());
                            return;
                        }
                        else
                        {
                            EquationNode node2 = generateOp();
                            n.add();
                            generate(node2, n);
                            node.setLeft(node1);
                            return;
                        }
                    }
                }
            }
        }

        //生成一个等式，调用生成函数，表示成树的形式
        public EquationNode generateEquation()
        {
            EquationNode root = generateOp();
            MyInt n = new MyInt();
            n.add();
            generate(root, n);
            for (int i = 0; i < nodes.Count; i++)
            {
                if (root.isEqual(nodes[i]))
                    return null;
            }
            return root;
        }

        public void generateQ()
        {
            for (int i = 0; i < numOfQ; i++)
            {
                EquationNode tree = generateEquation();
                if (tree == null)
                {
                    i--;
                    continue;
                }
                else
                {
                    Num answer = tree.compute(haveNegative);
                    if (answer == null)
                    {
                        i--;
                        continue;
                    }
                    nodes.Add(tree);
                    answers.Add(answer);
                }
            }
        }

        public void writeToFile(string questionFile, string answerFile)
        {
            StreamWriter writerQ = new StreamWriter(questionFile);
            StreamWriter writerA = new StreamWriter(answerFile);
            for (int i = 0; i < nodes.Count(); i++)
            {
                writerQ.WriteLine((i + 1) + ". " + nodes[i].toString());
                writerA.WriteLine((i + 1) + ". " + answers[i].toString());
            }
            writerQ.Close();
            writerA.Close();
        }
    }
}
