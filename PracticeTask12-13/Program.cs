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
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
        }
        static int[] Max_array(int[] array)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            for (int i = index + 1; i < array.Length;i++)
            {
                array[i] = 1;
            }
            return array;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
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
            Console.Write("Введите количество элементов в массиве: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(1, 100);
                B[i] = random.Next(1, 100);
            }
            Console.Write("Массив A до обработки:");
            printArray(A);
            Console.Write("Массив B до обработки:");
            printArray(B);
            Console.Write("Массив A после обработки:");
            printArray(Max_array(A));
            Console.Write("Массив B после обработки:");
            printArray(Max_array(B));
        }
    }
}
