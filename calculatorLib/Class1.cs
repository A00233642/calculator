using System;

namespace calculatorLib
{
    public  class Class1
    {
       




        public static double Division(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Cannot divide by zero", "b");
            }
        }
    }

}
    