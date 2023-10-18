using System.ComponentModel.Design;

namespace Matematical_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the 3numbers;");

            Console.Write("FirstNumber: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("SecondNumber: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("ThirdNumber: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                    Console.WriteLine("1st number is greater than others");

                else
                    Console.WriteLine("3rd number is the greater than others");
            }
            else if (secondNumber > thirdNumber)
            {
                Console.WriteLine("2rd number is the greater than others");

            else
                    Console.WriteLine("3rd number is the greater than others");

            }
            
            Console.ReadKey();
        }
    }
}
