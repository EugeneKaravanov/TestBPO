using CalculatorService.Models;

namespace CalculatorService.Services
{
    public class CalculatorC
    {
        public async Task<CalculateResult> Sum(int firstNumber, int secondNumber)
        {
            CalculateResult calculateResult = new CalculateResult();

            calculateResult.Result = firstNumber + secondNumber;
            calculateResult.isSuccess = true;

            return calculateResult;
        }

        public async Task<CalculateResult> Subtract(int firstNumber, int secondNumber)
        {
            CalculateResult calculateResult = new CalculateResult();

            calculateResult.Result = firstNumber - secondNumber;
            calculateResult.isSuccess = true;

            return calculateResult;
        }

        public async Task<CalculateResult> Multiplicat(int firstNumber, int secondNumber)
        {
            CalculateResult calculateResult = new CalculateResult();

            calculateResult.Result = firstNumber * secondNumber;
            calculateResult.isSuccess = true;

            return calculateResult;
        }

        public async Task<CalculateResult> Share(int firstNumber, int secondNumber)
        {
            CalculateResult calculateResult = new CalculateResult();

            if (secondNumber == 0)
            {
                calculateResult.Result = 0;
                calculateResult.isSuccess = false;
            }
            else
            {
                calculateResult.Result = firstNumber / secondNumber;
                calculateResult.isSuccess = true; ;
            }

            return calculateResult;
        }

        public async Task<CalculateResult> CalculateRoot(int number, int baseNumber)
        {
            CalculateResult calculateResult = new CalculateResult();

            if (number < 0 || baseNumber == 0)
            {
                calculateResult.Result = 0;
                calculateResult.isSuccess = false;
            }
            else
            {
                calculateResult.Result = (int)Math.Pow(number, 1 / baseNumber);
                calculateResult.isSuccess = true;
            }

            return calculateResult;
        }

        public async Task<CalculateResult> Exponent(int number, int degree)
        {
            CalculateResult calculateResult = new CalculateResult();

            calculateResult.Result = (int)Math.Pow(number, degree);
            calculateResult.isSuccess = true;

            return calculateResult;
        }
    }
}
