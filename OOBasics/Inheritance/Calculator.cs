using System;

namespace OOBasics.Inheritance
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Multiple(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b != 0 )
                return a / b;
            throw new Exception("Cannot divide by 0");
        }
    }
}