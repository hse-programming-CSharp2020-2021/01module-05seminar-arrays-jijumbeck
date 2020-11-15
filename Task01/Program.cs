using System;
using System.Text;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());
            
            int[] array = new int[numOfItems];
            // TODO: считайте массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int newValue; // значение, которым нужно заменить все максимальные элементы
            // TODO: считайте новое значение
            newValue = int.Parse(Console.ReadLine());

            Console.WriteLine(arrayString(array));
            ReplaceMaxElem(ref array, newValue);
            Console.WriteLine(arrayString(array));

            // TODO: реализуйте вывод необходимых данных
        }

        static public int Max(int[] a)
        {
            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static void ReplaceMaxElem(ref int[] arr, int val)
        {
            // TODO: реализуйте замену всех вхождений максимального элемента массива arr на значение val
            int max = Max(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == max)
                {
                    arr[i] = val;
                }
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