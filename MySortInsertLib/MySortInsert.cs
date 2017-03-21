using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortInsertLib
{
    public class MySortInsert
    {
        public static void Input(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void SortInsert(int[] a)
        {
            int t, j;
            for (int i = 1; i < a.Length; i++)
            {
                t = a[i];
                j = i;
                while (j > 0 && a[j - 1] < t)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = t;
            }
        }

        public static bool Equals(int[] objA, int[] objB)
        {
            if (objA == objB)
                return true;
            if (objA.Length != objB.Length)
                return false;
            for (int i = 0; i < objA.Length; ++i)
            {
                if (objA[i] != objB[i])
                {
                    return false;
                }
            }
            return true;
        }
/*
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие: 1-ввод массива с клавиатуры, 2-сортировка введенного массива и сверка");
            int v = Convert.ToInt32(Console.ReadLine());
            int[] nums;
            int n;
            int[] mas = { 1, 2, 3, 4 };
            //mas = { 4, 3, 2, 1 };
            int[] resmas = { 4, 3, 2, 1 };
            switch (v)
            {
                case (1):
                    // ввод чисел
                    Console.WriteLine("Введите размер массива");
                    n = Convert.ToInt32(Console.ReadLine());
                    nums = new int[n];
                    Console.WriteLine("Введите n чисел");
                    Input(nums);
                    Console.WriteLine("Вывод");
                    Output(nums);
                    SortInsert(nums);
                    Output(nums);
                    Console.ReadKey();
                    break;
                case (2):
                    n = 4;
                    Console.WriteLine("Вывод исходного массива: ");
                    Output(mas);
                    SortInsert(mas);
                    Console.WriteLine("Вывод отсортированного массива: ");
                    Output(mas);
                    Console.WriteLine("Сверка: ");
                    Console.Write("тест пройден ");
                    if (Equals(mas, resmas))
                        Console.WriteLine("успешно");
                    else Console.WriteLine("неуспешно");
                    Console.ReadKey();
                    break;
            }
        }*/
    }
}
