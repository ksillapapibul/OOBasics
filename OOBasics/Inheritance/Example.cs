using System;

namespace OOBasics.Inheritance
{
    public class Example
    {
        public static void Execute()
        {
            var advancedCalculator = new AdvancedCalculator();

            Print(advancedCalculator.Add(1, 2));
            Print(advancedCalculator.Substract(1, 2));
            Print(advancedCalculator.Divide(5, 2));
            Print(advancedCalculator.Power(3, 3));
            Print(advancedCalculator.Factorial(5));
        }

        private static void Print<T>(T t)
        {
            Console.WriteLine(t);
        }
    }
}