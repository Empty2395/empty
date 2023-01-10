using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Merge(int[] array,int lowIndex,int middleIndex,int highIndex)
        {
            var left = lowIndex; //nizkii
            var right = middleIndex + 1; //srednii
            var tempArray = new int[highIndex - lowIndex + 1];//highIndex - vicokii
            var index = 0;

            while ((left<= middleIndex)&&(right<= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;    
                }
                index++;
            }
            for (var i = left;i<=middleIndex;i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = right;i<=highIndex;i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = 0;i<tempArray.Length;i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
            static int[] MergeSort(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middleIndex);
            MergeSort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }

        return array;
    }
        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сортировка слиянием");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите элемент массива: ");
            var s = Console.ReadLine().Split(new[] {" ",",", ";"},StringSplitOptions.RemoveEmptyEntries);
            Random random= new Random();
            //random.Next(StringSplitOptions.RemoveEmptyEntries);
            var array = new int[s.Length];
            for (int i = 0;i<s.Length;i++)
            {
                array[i] = Convert.ToInt32(s[i]);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", MergeSort(array)));

                Console.ReadLine();
        }


    }
}



            //for (int i = 0;i< array.Length;i++)
            //{
            //    for (int j = 0; j < ;j++)
            //    {
            //    Console.WriteLine(array[i]);
            //
            //    }
            //}

            //string[] array = new string[] {"Roma","Tema","Ira","Sergeu","Rocki"};
            //for (int i = 0;i<array.Length;i++)
            //{
            //    Console.ForegroundColor= ConsoleColor.Green;
            //    Console.Write(array[i] + " ");
            //    Console.ResetColor();
            //}
            //Array.Sort(array);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("По алфавиту:");
            //Console.ResetColor();
            //int a = 1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("{0} {1}\n",a++ , array[i]);
            //    Console.ResetColor();
            //}
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("С конца алфавита:");
            //Console.ResetColor();
            //int f = 1;
            //Array.Reverse(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Write("{0} {1}\n", f++, array[i]);
            //    Console.ResetColor();
            //}





            //int temp;
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Vicod");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("{0} ", array[i]);

            //}





            



