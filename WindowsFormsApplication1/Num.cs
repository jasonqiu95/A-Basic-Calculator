using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Num
    {
        //public int integer;
        //bool valid;
        public int isPlus; //0 => 无负数，1 => 正数，2 => 负数

        public Num(int plus)
        {
            //integer = n;
            isPlus = plus;
            //valid = true;
        }

        public virtual bool isEqual(Num n)
        {
            if (isPlus == n.isPlus)
                return true;
            else return false;
        }

        public virtual Num add(Num num, bool haveNegative)
        {
            return null;
        }

        public virtual Num sub(Num num, bool haveNegative)
        {
            return null;
        }

        public virtual Num multi(Num num, bool haveNegative)
        {
            return null;
        }

        public virtual Num div(Num num, bool haveNegative)
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
