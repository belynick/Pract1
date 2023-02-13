using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше чило: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть друге чило: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Operation operation = Add; 
            int result = operation(a, b); 
            Console.WriteLine("Add: " + result); 

            operation = Sub; 
            result = operation(a, b); 
            Console.WriteLine("Sub: " + result); 

            operation = Mul; 
            result = operation(a, b); 
            Console.WriteLine("Mul: " + result);

            operation = Div;
            if (b == 0)
            {
                Console.WriteLine("Помилка! На нуль дiлити не можна!");
            }
            else
            {
            result = operation(a, b); 
            Console.WriteLine("Div: " + result);
            }

            int Add(int x, int y) => x + y;
            int Sub(int x, int y) => x - y;
            int Mul(int x, int y) => x * y;
            int Div(int x, int y) => x / y;

            Console.ReadLine();
        }
           public delegate int Operation(int x, int y);
    }
}

          
    
    



