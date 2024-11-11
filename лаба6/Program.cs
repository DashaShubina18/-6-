using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба6
{
    internal class Program
    {
        static int Sum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number1, number2, number3;
            Console.WriteLine("Введіть перше число");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третє число");
            number3 = Convert.ToInt32(Console.ReadLine());
            int sum1=Sum(number1);
            int sum2=Sum(number2);
            int sum3=Sum(number3);
            Console.WriteLine($"Сума цифр першого числа:" + sum1);
            Console.WriteLine($"Сума цифр другого числа:" + sum2);
            Console.WriteLine($"Сума цифр третього числа:" + sum3);



        }
    }
}
