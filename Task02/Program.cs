using System;
using System.Text;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }

        public static void RunTask02()
        {
            int N = int.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            int[] array = new int[N];
            FillArray(ref array);

            // TODO: выведите массив на экран

            Console.WriteLine(arrayString(array));


        }

        static void FillArray(ref int[] arr)
        {
            // TODO: заполните массив соответствующими данными
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)myPow(2, i);
            }
        }

        static double myPow(double x, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if (pow % 2 == 0)
            {
                double g = myPow(x, pow / 2);
                return g * g;
            }
            else
            {
                return x * myPow(x, pow - 1);
            }
        }
        static public string arrayString(int[] a)
        {
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                strb.Append($"{a[i]} ");
            }
            return strb.ToString();
        }
    }
}