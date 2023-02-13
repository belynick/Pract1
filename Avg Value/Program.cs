using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_Value
{
    internal class Program
    {
        delegate double MyDel(int[] vals);
        static void Main(string[] args)
        {
            Console.Write("Введiть перший елемент масиву: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введiть перший елемент масиву: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введiть перший елемент масиву: ");
            int z = int.Parse(Console.ReadLine());

            var array = new int[3];
            MyDel del = delegate (int[] vals)
            {
                vals[0] = x;
                vals[1] = y;
                vals[2] = z;
                double result = 0;
                for (int i = 0; i < vals.Length; i++)
                {
                    result += vals[i];
                }
                return result / array.Length;
            };

            Console.WriteLine("Cереднє арифметичне = {0}", del(array));

            Console.ReadLine();
        }
    }
}
