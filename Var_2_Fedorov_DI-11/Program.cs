using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_2_Fedorov_DI_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie_12();
        }
        private static void Zadanie_1()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        private static void Zadanie_2()
        {
            Console.WriteLine("Введите строку:");
            string Sctrochenka = Console.ReadLine();

            Console.WriteLine("Введите число N:");
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            while (counter < n)
            {
                Console.WriteLine(Sctrochenka);
                counter++;
            }
        }
        private static void Zadanie_3()
        {
            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.Write("S");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        private static void Zadanie_4()
        {
            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.Write(i * j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        private static void Zadanie_5()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        private static void Zadanie_6()
        {
            Console.WriteLine("Введите Числа M(Количество строк) и N(Количество знаков)");
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine();
            }
        }
        private static void Zadanie_7()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine();
            }
        }
        private static void Zadanie_8()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("8");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("8");
            }
        }
        private static void Zadanie_9()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Я никогда не буду работать за копейки.Ведь я хочу работать за капкейки!");
            }
        }
        private static void Zadanie_10()
        {
            Console.WriteLine("Введите 3 числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int min = Math.Min(a,Math.Min(b,c));
            int max = Math.Max(a, Math.Max(b,c));
            int avg = a + b + c - min - max;
            Console.WriteLine("Среднее из 3 введенных чисел: "+avg);
        }
        private static void Zadanie_11()
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите год рождения:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день рождения:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Меня зовут: "+name);
            Console.WriteLine("Я родился: " + y + m + d);

        }
        private static void Zadanie_12()
        {
            string[] strochka = new string[10];

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите строку:");
                strochka[i] = Console.ReadLine();
            }

            Console.WriteLine("Содержимое массива в обратном порядке:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(strochka[i]);
            }
        

        }
    }
    }



