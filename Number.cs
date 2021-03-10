using System;

namespace ConsoleTesting
{
  public   class Number
    {
        /// <summary>
        /// This method adds list of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>int</returns>
     public  int AddNumbers(params int[] numbers)
        {
            int result = 0;
            foreach(int number in numbers)
            {
                result += number;

            }
            return result;
        }
        /// <summary>
        /// This method add up list of double numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>double</returns>
        public double AddNumbers(params double[] numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;

            }
            return result;
        }
        /// <summary>
        /// This method multiply  list of double numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>double</returns>
        public double MultiplyNumbers(params double[] numbers)
        {
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;

            }
            return result;
        }
        /// <summary>
        /// This method multiply list of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>int</returns>
        public  int MultiplyNumbers(params int[] numbers)
        {
            int result = 1;
            foreach (int number in numbers)
            {
                result *= number;

            }
            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }catch(Exception)
            {
                throw;
            }
            return result;
        }
    }
}
