using System;

namespace SandboxTest.BLL
{
    public class MultiplicationService
    {
        public MultiplicationService()
        {

        }
        public decimal Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : throw new ArithmeticException();
        }
    }
}
