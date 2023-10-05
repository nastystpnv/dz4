

using System;

namespace ConsoleApp2
{
    internal class Program
    { static int FindMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    
        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static bool CalculateFactorial(int n, out long res)
        {
            try
            {
                checked
                {
                    res = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        res *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                res = 0;
                return false;
            }
        static bool CalculateFact(int n, out long res)
            static long (int n)
            {
                if (n == 0 || n == 1) return 1;   
                return n * (n - 1); // рекрусивный случай
            }
            static void Main(string[] args)
            {
                Console.WriteLine("лабораторная тумакова 5.1");
                Console.WriteLine("Введите первое число: ");
                if (int.TryParse(Console.ReadLine(), out int n1))
                {
                    Console.WriteLine("введите второе число: ");
                    if (int.TryParse(Console.ReadLine(), out int n2))
                    {
                        int result = FindMax(n1, n2);
                        Console.WriteLine("Наибольшее число: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода второго числа.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода первого числа.");
                }

                Console.WriteLine("лабораторная тумакова 5.2");
                Console.WriteLine("Введите первое число: ");
                if (int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Введите второе число: ");
                    if (int.TryParse(Console.ReadLine(), out int num2))
                    {
                        SwapNumbers(ref num1, ref num2);
                        Console.WriteLine("После обмена:");
                        Console.WriteLine("Первое число: " + num1);
                        Console.WriteLine("Второе число: " + num2);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода второго числа.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода первого числа.");
                }

                Console.WriteLine("лабораторная тумакова 5.3");
                Console.WriteLine("Введите число для вычисления факториала: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    if (CalculateFactorial(inputNumber, out long result))
                    {
                        Console.WriteLine($"Факториал числа {inputNumber} равен: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: переполнение в процессе вычисления факториала.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода числа.");
                }

                Console.WriteLine("лабораторная тумакова 5.4");
                Console.WriteLine("Введите число для вычисления факториала: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumb))
                {
                    long result = CalculateFact(inputNumber);
                    Console.WriteLine($"Факториал числа {inputNumber} равен: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода числа.");
                }
                // чет в этот полно ошибок, я растерялась, не пойму, что исправлять....
            }

        }
        
    }
}

