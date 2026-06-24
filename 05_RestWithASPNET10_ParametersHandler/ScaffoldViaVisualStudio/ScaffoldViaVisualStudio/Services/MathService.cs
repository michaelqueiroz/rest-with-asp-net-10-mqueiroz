namespace ScaffoldViaVisualStudio.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;
        public decimal mean(decimal firstNumber, decimal secondNumber) => (firstNumber + secondNumber) / 2;
        public decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;
        public decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;
        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return firstNumber / secondNumber;
        }
        public double SquareRoot(decimal firstNumber)
        {
            if(firstNumber < 0) throw new ArgumentOutOfRangeException("Cannot calculate square root of a negative number.");
            return Math.Sqrt((double)firstNumber);
        }
        
    }
}
