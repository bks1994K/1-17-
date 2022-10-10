using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_17_1
{
    public static class ArrayHandler

    //  1.17. Введение в массивы
    //1

    {
        public static int FindMinElementOfArray(int[] arrays)
        {
            int min = arrays[0];
            for (int i = 1; i < arrays.Length; i++)
            {
                if (min > arrays[i])
                {
                    min = arrays[i];
                }
            }
            return min;
        }


        //2
        public static int FindMaxElementOfArray(int[] arrays)
        {
            int max = arrays[0];
            for (int i = 1; i < arrays.Length; i++)
            {
                if (max < arrays[i])
                {
                    max = arrays[i];
                }
            }
            return max;
        }

        //3

        public static int FindIndexOfMinElementOfArray(int[] arrays)
        {

            int min = arrays[0];
            int n = 0;
            for (int i = 1; i < arrays.Length; i++)
            {
                if (min > arrays[i])
                {
                    min = arrays[i];
                    n = i;
                }
            }
            return n;
        }

        //4

        public static int FindIndexOfMaxElementOfArray(int[] arrays)
        {

            int max = arrays[0];
            int n = 0;
            for (int i = 1; i < arrays.Length; i++)
            {
                if (max < arrays[i])
                {
                    max = arrays[i];
                    n = i;
                }
            }
            return n;
        }

        //5

        public static int SummElementsWithOddIndexOfArray(int[] arrays)
        {

            int n = 0;
            int summ = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                n = i;
                int tmp = n % 2;
                if (tmp != 0)
                {
                    summ = summ + arrays[i];
                }
            }
            return summ;
        }

        //6

        public static int[] MirroredArray(int[] arrays)
        {
            int[] mirrow = new int[arrays.Length];
            int k = -1;
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                k = k + 1;
                mirrow[k] = arrays[i];
            }
            return mirrow;
        }

        //6.1

        public static void WriteArrayToConsole(int[] arrays)
        {

            for (int i = 0; i < arrays.Length; i++)

            {
                Console.Write($"{arrays[i]} ");
            }
            Console.WriteLine();
        }

        //7

        public static int CountOddElementsInArray(int[] arrays)
        {
            int count = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                int tmp = arrays[i] % 2;
                if (tmp != 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        //8

        public static int[] SwappedHalfOTheArray(int[] arrays)
        {
            int[] swapped = new int[arrays.Length];

            int count = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                count = count + 1;
            }

            int leftEven = count / 2;
            int index = count - leftEven;
            for (int j = 0; j < leftEven; j++)
            {
                swapped[index] = arrays[j];
                index = index + 1;
            }
            index = 0;
            for (int k = leftEven; k <= count - 1; k++)
            {
                swapped[index] = arrays[k];
                index = index + 1;
            }

            return swapped;
        }



        // 1.18.1. Отсортировка массива пузырьком по возрастанию

        public static int[] Sort(int[] sortAsc)
        {
            for (int i = 0; i < sortAsc.Length; i++)
            {
                for (int j = 0; (j < sortAsc.Length - i && j < sortAsc.Length - 1); j++)
                {
                    if (sortAsc[j] > sortAsc[j + 1])
                    {
                        int tmp = sortAsc[j + 1];
                        sortAsc[j + 1] = sortAsc[j];
                        sortAsc[j] = tmp;
                    }
                }
            }
            return sortAsc;

        }

        // 1.18.2. Сортировка массива вставками по убыванию

        public static int[] SortDesc(int[] sortDesc)
        {
            for (int i = 1; i < sortDesc.Length; i++)
            {
                int j = i;
                while ((j >= 1) && (sortDesc[j - 1]< sortDesc[j]))
                {
                    int tmp = sortDesc[j];
                    sortDesc[j] = sortDesc[j - 1];
                    sortDesc[j - 1] = tmp;
                    j = j - 1;
                }
            }
            return sortDesc;
        }


    }
}