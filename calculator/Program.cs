using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите действие(+, -, *, :)");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Получается");

            if (oper == '+')
            {
                Console.WriteLine(x + y);
            }
            else if (oper == '-')
            {
                Console.WriteLine(x - y);
            }
            else if (oper == '*')
            {
                Console.WriteLine(x * y);
            }
            else if (oper == ':')
            {
                Console.WriteLine(x / y);
            }
            Console.ReadKey(true);

        }
    }
}
