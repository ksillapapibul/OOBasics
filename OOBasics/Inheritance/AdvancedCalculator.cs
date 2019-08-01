namespace OOBasics.Inheritance
{
    public class AdvancedCalculator : Calculator
    {
        public int Power(int a, int b)
        {
            var powerValue = 1;
            for (var i = 0; i < b; i++)
            {
                powerValue *= a;
            }

            return powerValue;
        }

        public int Factorial(int n)
        {
            if (n == 0 || n== 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}