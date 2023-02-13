using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_Del
{
    internal class Program
    {
        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] dels);
        private static Random random = new Random();

        static int GetRandom()
        {
            int number = random.Next(1, 10);
            Console.WriteLine(number);
            return number;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть елементiв масиву: ");
            int number = int.Parse(Console.ReadLine());

            var array = new MyDelegate[number];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom)();
            }

            MyDel del = delegate (MyDelegate[] dels)
            {
                double result = 0;
                for (int i = 0; i < dels.Length; i++)
                {
                    result += dels[i]();
                }
                return result / array.Length;
            };

            Console.WriteLine("Cереднє арифметичне = {0}", del(array));

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]());
            }

            Console.ReadLine();
        }
    }
}
