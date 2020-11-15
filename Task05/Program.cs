using System;
using System.Text;

/*
 * Пользователем с клавиатуры вводится целое число N > 1.
 * В программе сформировать целочисленный массив,
 * содержащий N первых элементов последовательности Фибоначчи:
 * A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
 * 
 * Формирование массива организовать при помощи метода.
 * Элементы массива вывести на экран в обратном порядке.
 * Методы класса Array НЕ использовать.
 *
 * Пример входных данных:
 * 5
 *
 * Пример выходных данных:
 * 5 3 2 1 1
 */

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask05();
        }

        public static void RunTask05()
        {
            int N = int.Parse(Console.ReadLine());

            // TODO: объявите массив и вызовите метод для его заполнения
            int[] arr = new int[N];
            FillArray(ref arr);
            ReverseArray(ref arr);

            // TODO: выведите массив на экран в требуемом порядке
            Console.WriteLine(arrayString(arr));
        }

        static public void FillArray(ref int[] arr)
        {
            arr[0] = 1;
            if(arr.Length > 1)
            {
                arr[1] = 1;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }

        static public void ReverseArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int change = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = change;
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