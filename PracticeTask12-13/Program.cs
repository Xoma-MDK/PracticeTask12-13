using System;

namespace PracticeTask12_13
{
    internal class Program
    {
        static int Fact(int a)
        {
            if (a == 0) return 1;
            return a * Fact(a - 1);
        }
        static int Combinations(int n, int m)
        {
            return Fact(n) / (Fact(m)*Fact(n-m));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            if (n > m)
            {
                Console.WriteLine($"Число сочетаний из n по m: {Combinations(n, m)}");
            }
            else
            {
                Console.WriteLine("ошибка: n должно быть больше m");
            }
        }
    }
}
