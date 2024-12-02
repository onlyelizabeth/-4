using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        protected double re;
        protected double im;

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }

        public MyComplex Substract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(this.re * that.re - this.im * that.im, this.re * that.im + this.im * that.re);
        }

        public MyComplex Divide(MyComplex that)
        {
            if (that.re * that.re + that.im * that.im == 0)
            {
                throw new System.DivideByZeroException("An attempt to divide by zero.");
            }
            else
            {
                return new MyComplex(((this.re * that.re + this.im * that.im) / (that.re * that.re + that.im * that.im)), ((this.im * that.re - this.re * that.im) / (that.re * that.re + that.im * that.im)));
            }
        }

        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
}
