using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input one number: ");
                    double Number1;
                    if (!double.TryParse(Console.ReadLine(), out Number1)) { Console.WriteLine("Invalid input provided."); break; }
                    Console.Write("Input the mathematic operator: ");
                    char Operator;
                    if (!char.TryParse(Console.ReadLine(), out Operator)) { Console.WriteLine("Invalid input provided."); break; }
                    Console.Write("Input another number: ");
                    double Number2;
                    if (!double.TryParse(Console.ReadLine(), out Number2)) { Console.WriteLine("Invalid input provided."); break; }
                    switch (Operator)
                    {
                        case '+':
                            Console.Write("Result: " + (Number1 + Number2));
                            break;
                        case '-':
                            Console.Write("Result: " + (Number1 - Number2));
                            break;
                        case '*':
                            Console.Write("Result: " + (Number1 * Number2));
                            break;
                        case '/':
                            Console.Write("Result: " + (Number1 / Number2));
                            break;
                        case '^':
                            Console.Write("Result: " + (Math.Pow(Number1, Number2)));
                            break;
                        default:
                            Console.Write("Invalid operator.");
                            break;
                    }
                    Task.Delay(1500).Wait();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }
        }
    }
}