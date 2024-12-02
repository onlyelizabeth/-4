using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_1
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        protected BigInteger nom;
        protected BigInteger denom;

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
        }

        public MyFrac(int nom, int denom)
        {
            this.nom = nom;
            this.denom = denom;
        }

        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }

        public MyFrac Substract(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom - that.nom * this.denom, this.denom * that.denom);
        }

        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(this.nom * that.nom, this.denom * that.denom);
        }

        public MyFrac Divide(MyFrac that)
        {
            if (this.denom * that.nom == 0)
            {
                throw new System.DivideByZeroException("An attempt to divide by zero.");
            }
            else
            {
                return new MyFrac(this.nom * that.denom, this.denom * that.nom);
            }
        }

        public int CompareTo(MyFrac that)
        {
            BigInteger difference = nom * that.denom - denom * that.nom;
            
            if(difference < 0)
            {
                return -1;
            }
            else
            {
                if (difference > 0)
                {
                    return 1;
                }
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    }
}
