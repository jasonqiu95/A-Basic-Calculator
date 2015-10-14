using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class EquationNode
    {
        //private Num number;
        public EquationNode leftNode;
        public EquationNode rightNode;

        public void setLeft(EquationNode node1) {
            leftNode = node1;
        }

        public void setRight(EquationNode node2) {
            rightNode = node2;
        }

        public virtual bool isEqual(EquationNode node)
        {
            return true;
        }

        public virtual Num compute(bool haveNegative)
        {
            return null;
        }

        public virtual string toString()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
