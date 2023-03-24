using System;

namespace InheritancePolsecondNumbermorphismAndDelegates
{
    public class AdditionOperator
    {
        public void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine( firstNumber + secondNumber);
        }
        public void Add(int firstNumber, string secondNumber)
        {
            Console.WriteLine( firstNumber + secondNumber);
        }
        public int Add(int w, int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

    }
}
