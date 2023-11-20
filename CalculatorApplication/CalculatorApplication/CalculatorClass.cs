using System;

namespace CalculatorApplication
{
    public class CalculatorClass
    {
        public delegate double Information(double arg1, double arg2);

        private event Information CalculateEvent;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new ArgumentException("Cannot divide by zero.");
        }

        public void Subscribe(Information method)
        {
            CalculateEvent += method;
        }

        public void Unsubscribe(Information method)
        {
            CalculateEvent -= method;
        }

        public double Calculate(double num1, double num2)
        {
            return CalculateEvent?.Invoke(num1, num2) ?? 0;
        }
    }
}
