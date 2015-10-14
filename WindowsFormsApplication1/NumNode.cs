using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class NumNode : EquationNode
    {
        private Num content;

        public NumNode(Num num)
        {
            content = num;
        }

        public override bool isEqual(EquationNode node)
        {
            if (node is NumNode)
            {
                if (content.isEqual(((NumNode)node).content))
                    return true;
            }
            return false;
        }

        public override Num compute(bool haveNegative)
        {
            return content;
        }

        public override string toString()
        {
            return content.toString();
        }

        public override string ToString()
        {
            return content.ToString();
        }
    }
}
