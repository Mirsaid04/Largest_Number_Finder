using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Matematical_Operation.Classes;

namespace Matematical_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo = "";
            do
            {
                CalculationProcess calculation = new CalculationProcess();

                calculation.Calculate();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Do you want to continue [y/n]: ");
                yesOrNo = Console.ReadLine()!;
                Console.ResetColor();
                if (yesOrNo =="y" || yesOrNo == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered invalid input");
                }

                } while (yesOrNo == "y") ;

        }
    }
}
