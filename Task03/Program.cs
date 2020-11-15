using System;
using System.Text;

/*
 * Пользователем с клавиатуры вводится целое число N > 0.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов,
 * элементами которого являются нечетные числа от 1.
 * Заполнение массива нечётными числами организовать при помощи метода.​
 *
 * Пример входных данных:
 * 7
 *
 * Пример выходных данных:
 * 1 3 5 7 9 11 13
 */

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask03();
        }

        public static void RunTask03()
        {
            int N = int.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            int[] a = new int[N];
            FillArray(ref a);
            // TODO: выведите массив на экран
            Console.WriteLine(arrayString(a));
        }

        static void FillArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 2 * i + 1;
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