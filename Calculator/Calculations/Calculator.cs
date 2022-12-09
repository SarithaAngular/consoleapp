

namespace Calculations
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        protected int Div(int x, int y)
        {
            return x / y;
        }
        protected internal int Mul(int x, int y)
        {
            return x * y;
        }
        internal int Mod(int x, int y)
        {
            return x % y;
        }
    }
}
