using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    public class ArrayExample
    {
        static void Main(string[] args)
        {
            // Standart dizi tanımlama ve başlatma
            int[] numbers = new int[5]; // 5 elemanlı bir dizi
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Alternatif olarak dizi tanımlama ve başlatma
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

            // Daha kısa bir yol
            int[] numbers3 = { 1, 2, 3, 4, 5 };

            // Yeni bir özellik: Collection expressions
            // var numbers4 = [1, 2, 3, 4, 5]; // C# 12'de collection expressions kullanarak dizi başlatma




            int[] squares = new int[10];
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = i * i;
            }

            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }





            // İki boyutlu dizi tanımlama
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            // İki boyutlu dizi başlatma
            int[,] matrix2 = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

            // İki boyutlu diziyi döngüyle yazdırma
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }




            // Üç boyutlu dizi tanımlama
            int[,,] threeD = new int[2, 2, 2];
            threeD[0, 0, 0] = 1;
            threeD[0, 0, 1] = 2;
            threeD[0, 1, 0] = 3;
            threeD[0, 1, 1] = 4;
            threeD[1, 0, 0] = 5;
            threeD[1, 0, 1] = 6;
            threeD[1, 1, 0] = 7;
            threeD[1, 1, 1] = 8;

            // Üç boyutlu diziyi döngüyle yazdırma
            for (int i = 0; i < threeD.GetLength(0); i++)
            {
                for (int j = 0; j < threeD.GetLength(1); j++)
                {
                    for (int k = 0; k < threeD.GetLength(2); k++)
                    {
                        Console.Write(threeD[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }




            // Jagged array tanımlama ve başlatma
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Jagged array'i döngüyle yazdırma
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }



            int[] unsortedArray = { 5, 3, 8, 1, 2 };
            Array.Sort(unsortedArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", unsortedArray));




            int[] arrayToReverse = { 1, 2, 3, 4, 5 };
            Array.Reverse(arrayToReverse);
            Console.WriteLine("Reversed Array: " + string.Join(", ", arrayToReverse));




            int[] searchArray = { 1, 2, 3, 4, 5 };
            int index = Array.IndexOf(searchArray, 3);
            Console.WriteLine("Index of 3: " + index);



            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] copiedArray = new int[originalArray.Length];
            Array.Copy(originalArray, copiedArray, originalArray.Length);
            Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));





            int[] linqArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtreleme
            var evenNumbers = linqArray.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            // Seçme
            var squares1 = linqArray.Select(n => n * n).ToArray();
            Console.WriteLine("Squares: " + string.Join(", ", squares));

            // Toplama
            int sum = linqArray.Sum();
            Console.WriteLine("Sum: " + sum);

        }

    }
}
