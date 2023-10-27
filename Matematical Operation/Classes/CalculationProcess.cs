namespace Matematical_Operation.Classes
{
    internal class CalculationProcess
    {
        public void Calculate()
        {
            Console.WriteLine("Please enter 3 numbers one by one ! ");

            Console.Write("FirstNumber: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("SecondNumber: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("ThirdNumber: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1st number is greater than others");
                    Console.ResetColor();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3rd number is the greater than others");
                    Console.ResetColor();
                }
            }
            else if (secondNumber > thirdNumber)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2nd number is the greater than others");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3rd number is the greater than others");
                Console.ResetColor();
            }
        }
    }
}
